using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Journal.Models
{
    public class Entry
    {
        [Key]
        public int EntryId {get; set;}

        [Required(ErrorMessage="is required.")]
        [MinLength(2, ErrorMessage="must be at least 2 characters")]
        [Display(Name="Title")]
        public string Title {get; set;}

        [Required(ErrorMessage="is required.")]
        [MinLength(10, ErrorMessage="must be at least 10 characters")]
        [Display(Name="Description")]
        public string Description {get; set;}

        [DataType(DataType.Date)]
        [FutureDate]
        public DateTime? Date {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public int UserId {get; set;}
    }
}