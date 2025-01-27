using System.ComponentModel.DataAnnotations;

namespace TodoList.Models.Account
{
    public class AccountViewModel
    {
        public LoginViewModel LoginViewModel { get; set; }
        public RegisterViewModel RegisterViewModel { get; set; }
        
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage ="This field is required")]
        public string Login {  get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }
    }
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "This field is required")]
        public string Login { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Compare("Password", ErrorMessage ="Passwords is not the same")]
        public string RepeatPassword { get; set; }
    }
}
