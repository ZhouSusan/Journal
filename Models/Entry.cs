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
        [Display(name="Title")]
        public string Title {get; set;}

        [Required(ErrorMessage="is required.")]
        [MinLength(10, ErrorMessage="must be at least 10 characters")]
        [Display(name="Description")]
        public string Description {get; set;}

        [Required(ErrorMessage="is required.")]
        [Display(DataType.Date)]
        [FutureDate]
        public DateTime? Date {get; set;}

        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}

        public UserId {get; set;}
    }
}