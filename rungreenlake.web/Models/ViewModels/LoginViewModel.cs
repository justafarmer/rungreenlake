/*
 *+++LoginViewModel+++
 * This is the loginview model, allowing a user to enter their 
 * username and password and login.
 * This is an old version.
 * 
*/

using System.ComponentModel.DataAnnotations;

namespace rungreenlake.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(255)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }

    }
}
