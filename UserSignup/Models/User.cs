using System;
using System.ComponentModel.DataAnnotations;

namespace UserSignup.Models
{
    public class User
    {
        [Required(ErrorMessage = "You must input a username!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "You must input an email address!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must input a password!")]
        public string Password { get; set; }

        public User()
        {

        }
    }
}
