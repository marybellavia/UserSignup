using System;
using System.ComponentModel.DataAnnotations;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {

        [Required(ErrorMessage = "You must input a username")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "You must input a password 6 character or longer.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name ="Verify Password")]
        public string Verify { get; set; }

        public AddUserViewModel()
        {
        }
    }
}
