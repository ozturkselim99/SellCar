using System.ComponentModel.DataAnnotations;

namespace sellcar.webui.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş bırakılamaz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılamaz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifrenizi tekrar giriniz.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler biribiri ile eşleşmiyor.")]
        public string RePassword { get; set; }
        [Required(ErrorMessage = "Email  alanı boş bırakılamaz.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Adres  alanı boş bırakılamaz.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Telefon  alanı boş bırakılamaz.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
