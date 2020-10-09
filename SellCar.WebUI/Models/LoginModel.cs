using System.ComponentModel.DataAnnotations;

namespace sellcar.webui.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email adresinizi giriniz.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
