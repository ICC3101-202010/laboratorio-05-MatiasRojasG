using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Lab5POO;

namespace Lab5POO
{
    public class User
    {
        public delegate void EmailVerificationEventHandler(object source, EmailVerificationEventArgs args);
        public event EmailVerificationEventHandler EmailVerified;
        protected virtual void OnEmailVerified(string username, string email)
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, new EmailVerificationEventArgs() { Username = username, Email = email });
            }
        }

        protected virtual void OnEmailSent(string username, string email)
        {
            // Verifica si hay alguien suscrito al evento
            if (EmailVerified != null)
            { // Engatilla el evento
                    EmailVerified(this, new EmailVerificationEventArgs() { Username = username, Email = email });
             
            }

        }

        public void OnEmailSent(object source, EmailSendEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}:  \n {e.Username}, te notificamos que ha sido enviado el correo. \n");
            Thread.Sleep(2000);
        }

        
    }
}
