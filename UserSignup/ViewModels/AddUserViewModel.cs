using System;
using System.ComponentModel.DataAnnotations;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {

        [Required(ErrorMessage = "You must input a username")]
        public string Username { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage = "You must input a password 6 character or longer.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must have a matching password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name ="Verify Password")]
        public string Verify { get; set; }

        public AddUserViewModel()
        {
        }

    }
}
