using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Steam_.Models
{
    public class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public double Cash { get; set; }
        public Account(string name,string email,string passWord,double cash)
        {
            Name = name;
            Email = email;
            PassWord = passWord;
            Cash = cash;
        }
        public void ShowInfo(string Name, string Email, string PassWord, double Cash)
        {
            Console.WriteLine($"Name:{Name} E-Mail:{Email} Password:{PassWord} Cash:{Cash}");
        }
    }
}
