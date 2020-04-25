using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Lab5POO;

namespace Lab5POO
{
    public class User
    {
        // Paso 1: Creamos el delegate para el evento de mandar mail de verificacion
        public delegate void EmailVerificationEventHandler(object source, EmailVerificationEventArgs args);
        // Paso 2: Creamos el evento que se engatilla cuando se verifica el mail
        public event EmailVerificationEventHandler EmailVerified;
        //Metodo
        protected virtual void OnEmailSent(string username, string email)
        {
            string respuesta;
            Console.WriteLine("¿Desea Verificar su mail?");
            respuesta = Console.ReadLine();
            if (respuesta=="Si")
            {
                EmailVerified(this, new EmailVerificationEventHandler() {Username=username, Email=email} );
            }
        }
    }
}
