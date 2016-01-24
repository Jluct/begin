using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication10.Models;

namespace WebApplication10.ViewModels
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
             Form = new LoginFormModel();
        }
        public string Title { get; set; }
        public LoginFormModel Form { get; set; }

        public List<Book> Books { get; set; }
    }
}