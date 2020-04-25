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


        protected virtual void OnEmailSent(string username, string email)
        {
            // Verifica si hay alguien suscrito al evento
            if (EmailVerified != null)
            {
                string respuesta;
                Console.WriteLine("¿Desea confirmar su correo?");
                respuesta = Console.ReadLine();
                if (respuesta == "Si")
                {
                    // Engatilla el evento
                    EmailVerified(this, new EmailVerificationEventArgs() { Username = username, Email = email });
                }
            }
        }
    }
}
