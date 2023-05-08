using System.ComponentModel.DataAnnotations;

namespace Identity.API.ViewModels
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "O nome precisa ser preenchido")]
        [MinLength(3, ErrorMessage = "O nome precisa ter mais de 3 caracteres")]
        [MaxLength(50, ErrorMessage = "O nome não pode ter mais de 50 caracteres")]

        public string Name { get; set; }
        [Required(ErrorMessage = "O email precisa ser preenchido")]
        [MinLength(10, ErrorMessage = "O email precisa ter mais de 30 caracteres")]
        [MaxLength(180, ErrorMessage = "O email não pode ter mais de 180 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha precisa ser preenchido")]
        [MinLength(8, ErrorMessage = "A senha precisa ter mais de 8 caracteres")]
        [MaxLength(80, ErrorMessage = "A senha não pode ter mais de 80 caracteres")]
        public string Password { get; set; }
    }
}