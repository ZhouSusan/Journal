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
        [Display(Name="First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name="Last name")]
        public string LastName {get; set;}

        [Required(ErrorMessage="is required.")]
        [EmailAddress]
        [Display(Name="Email")]
        public string Email {get; set;}

        [DataType(DataType.Password)]
        [Required(ErrorMessage="is required.")]
        [MinLength(8, ErrorMessage="must be 8 characters or longer!")]
        [Display(Name="Password")]
        public string Password {get; set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [Compare("Password", ErrorMessage="doesn't match with password")]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        public string PasswordConfirm {get; set;}

        public List<Entry> CreatedEntries {get; set;}
    }
}