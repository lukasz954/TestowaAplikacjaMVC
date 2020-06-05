using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektTestowy.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Podaj login")]
        public string Login { get; set; }


        [Display(Name = "Hasło")]
        [Required(ErrorMessage = "Podaj hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}