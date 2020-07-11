using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jot.Models
{
    public class Folder
    {
        [Key]
        public int FolderId {get;set;}

        [Required (ErrorMessage = "Folder name is required.")]
        [MinLength (2, ErrorMessage = "Folder name must be at least 2 characters.")]
        [Display (Name = "Folder:")]

        public string FolderName {get;set;}
        public List<Note> Notes {get;set;}

        public DateTime CreatedAt {get;set;}=DateTime.Now; 
        public DateTime UpdatedAt {get;set;}=DateTime.Now;

    }
}