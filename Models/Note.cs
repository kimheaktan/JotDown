using System;
using System.ComponentModel.DataAnnotations;

namespace Jot.Models
{
    public class Note
    {
        [Key]
        public int NoteId {get;set;}
        public int FolderId {get;set;}

        public Folder Folder {get;set;}

        [Required (ErrorMessage = "Note name is required.")]
        [MinLength (2, ErrorMessage = "Note name must be at least 2 characters.")]
        [Display (Name = "Details:")]
        public string NoteName {get;set;}

        [Required (ErrorMessage = "Note details are required.")]
        [MinLength (2, ErrorMessage = "Note details must be at least 2 characters.")]
        [Display (Name = "Details:")]

        public string Details {get;set;}
        public DateTime CreatedAt {get;set;}=DateTime.Now; 
        public DateTime UpdatedAt {get;set;}=DateTime.Now;

    }
}