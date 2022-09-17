using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Journal.Models
{
    public class User
    {
        [Key] 
        public int UserId { get; set; }

        [Required(ErrorMessage="is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(name="First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(name="Last name")]
        public string LastName {get; set;}

        [Required(ErrorMessage="is required.")]
        [EmailAddress]
        [Display(name="Email")]
        public string Email {get; set;}

        [DataType(DataType.Password)]
        [Required(ErrorMessage="is required.")]
        [MinLength(8, ErrorMessage="must be 8 characters or longer!")]
        [Display(name="Password")]
        public string Password {get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [Compare("Password", ErrorMessage="doesn't match with password")]
        [DataType(DataType.Password)]
        [Display(name="Confirm Password")]
        public string PasswordConfirm {get; set;}

        public List<Entry> CreatedEntries {get; set;}
    }
}