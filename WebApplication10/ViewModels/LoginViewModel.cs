using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication10.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
             Form = new LoginFormModel();
        }
        public string Title { get; set; }
        public LoginFormModel Form { get; set; }
    }
    public class LoginFormModel
    {
        [DisplayName("Логин")]
        
        public string Login { get; set; }
        public string Password { get; set; }

    }
}