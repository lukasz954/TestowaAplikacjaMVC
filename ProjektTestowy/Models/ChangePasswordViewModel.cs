using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektTestowy.Models
{
    public class ChangePasswordViewModel
    {
        [DisplayName("Login")]
        [Required(ErrorMessage = "Proszę podać login.")]
        public string Login { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Proszę podać adres e-mail.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Proszę podać prawidłowy adres e-mail.")]
        public string Email { get; set; }


        [DisplayName("Nowe hasło")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Proszę podać nowe hasło.")]
        public string NewPassword { get; set; }
    }
}