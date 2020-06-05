using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektTestowy.Models
{
    public class SuccessfullLoginViewModel
    {
        public SuccessfullLoginViewModel(string userName)
        {
            UserName = userName;
        }

        public string UserName{ get; set; }
    }
}