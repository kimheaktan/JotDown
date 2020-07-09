using System.Collections.Generic;

namespace Jot.Models
{
    public class allFoldersModel
    {
        public Note note {get;set;}
        public Folder folder {get;set;}
        public List<Folder> allFolders {get;set;}
        public List<Note> allNotes {get;set;}
    }
}