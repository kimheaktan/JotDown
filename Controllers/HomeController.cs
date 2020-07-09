using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Jot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Jot.Controllers
{
    public class HomeController : Controller
    {
        private JotContext _db; 

        public HomeController(JotContext context) 

        { 

        _db = context; 

        }
        public IActionResult Index()
        {
            List<Folder> folders = _db.Folders.Include(f =>f.Notes).OrderBy(f => f.FolderName).ToList();
            List<Note> notes = _db.Notes.Include(n => n.Folder).OrderBy(n => n.NoteName).ToList();
            allFoldersModel info = new allFoldersModel{
                allFolders = folders,
                allNotes = notes
            };
            return View(info);
        }

        public IActionResult NewFolder()
        {
            List<Folder> folders = _db.Folders.Include(f => f.Notes).OrderBy(f => f.FolderName).ToList();
            allFoldersModel info = new allFoldersModel{
                allFolders = folders
            };
            return View(info);
        }
        public IActionResult CreateFolder(Folder folder)
        {
            if(ModelState.IsValid)
            {
                _db.Folders.Add(folder);
                _db.SaveChanges();

                return RedirectToAction("NewFolder");
            }
            List<Folder> folders = _db.Folders.Include(f => f.Notes).OrderBy(f => f.FolderName).ToList();
            allFoldersModel info = new allFoldersModel{
                allFolders = folders
            };
            return View("NewFolder" ,info);
        }

        public IActionResult NewNote()
        {
            List<Folder> folders = _db.Folders.Include(f => f.Notes).OrderBy(f => f.FolderName).ToList();
            allFoldersModel info = new allFoldersModel{
                allFolders = folders
            };
            return View (info);
        }
        public IActionResult CreateNote(allFoldersModel inputNote)
        {
            if(ModelState.IsValid)
            {
                Note newNote = new Note{
                    NoteName = inputNote.note.NoteName,
                    Details = inputNote.note.Details,
                    FolderId = inputNote.note.FolderId
                };
                _db.Notes.Add(newNote);
                _db.SaveChanges();

                return RedirectToAction("NewNote");
            }
            List<Folder> folders = _db.Folders.Include(f => f.Notes).OrderBy(f => f.FolderName).ToList();
            allFoldersModel info = new allFoldersModel{
                allFolders = folders
            };
            return View ("NewNote",info);
        }

        public IActionResult ViewFolder(int folderID )
        {
            Folder thisFolder = _db.Folders.Include(f => f.Notes).FirstOrDefault(f => f.FolderId == folderID);
            HttpContext.Session.SetInt32("folderId", folderID );

            List<Folder> folders = _db.Folders.Include(f => f.Notes).OrderBy(f => f.FolderName).ToList();
            allFoldersModel info = new allFoldersModel{
                allFolders = folders,
                folder = thisFolder
            };

            return View(info);
        }

        public IActionResult ViewNote()
        {
            return View();
        }

        public IActionResult DeleteNote(int noteID, int folderID)
        {
            Note TBDeleted = _db.Notes.FirstOrDefault(n => n.NoteId == noteID);

            Folder thisFolder = _db.Folders.Include(f => f.Notes).FirstOrDefault(f => f.FolderId == TBDeleted.FolderId);
            HttpContext.Session.SetInt32("folderId", thisFolder.FolderId );


            List<Folder> folders = _db.Folders.Include(f => f.Notes).OrderBy(f => f.FolderName).ToList();
            List<Note> notes = _db.Notes.Include(n => n.Folder).OrderBy(n => n.NoteName).ToList();

            allFoldersModel info = new allFoldersModel{
                allFolders = folders,
                folder = thisFolder,
                allNotes = notes
            };
            _db.Remove(TBDeleted);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
