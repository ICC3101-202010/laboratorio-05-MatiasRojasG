﻿using System;
using System.Collections.Generic;
using System.Text;
using Lab5POO;

namespace Lab5Poo
{
    public class RegisterEventArgs : EventArgs
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerificationLink { get; set; }
    }
}
