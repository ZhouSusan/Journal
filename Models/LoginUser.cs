using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Journal.Models
{
    public class LoginUser
    {
    [NotMapped]
    [Display(name="Email")]
    [Required(ErrorMessage="is required.")]
    [EmailAddress]
    public string LoginEmail {get; set;}

    [Display(name="Password")]
    [Required(ErrorMessage="is required.")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage="Must be 8 characters or longer!")]
    public string LoginPassword {get; set;}
    }
}