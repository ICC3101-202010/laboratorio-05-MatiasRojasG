using System;
using System.Collections.Generic;
using System.Text;
using Lab5POO;

namespace Lab5Poo
{
    public class ChangePasswordEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Number { get; set; }
        public string Username { get; set; }
    }
}
