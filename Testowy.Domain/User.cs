using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testowy.Domain
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Podaj login.")]
        public string Login { get; set; }

        [Display(Name = "Hasło")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }

        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Podaj nazwe użytkownika.")]
        [MinLength(3)]
        public string Name { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Proszę podać prawidłowy adres e-mail.")]
        [Required(ErrorMessage = "Podaj e-mail.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
