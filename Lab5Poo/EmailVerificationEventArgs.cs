﻿using System;
using System.Collections.Generic;
using System.Text;
using Lab5POO;

namespace Lab5POO
{
    public class EmailVerificationEventArgs : EventArgs
    {
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
