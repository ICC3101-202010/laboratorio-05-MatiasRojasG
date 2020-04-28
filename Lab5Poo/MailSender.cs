using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Lab5POO;

namespace Lab5Poo
{
    public class MailSender
    {
        public void OnRegistered(object source, RegisterEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}: \n Gracias por registrarte, {e.Username}!\n Por favor, para poder verificar tu correo, has click en: {e.VerificationLink}\n");
            Thread.Sleep(2000);
        }

        public void OnPasswordChanged(object source, ChangePasswordEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}:  \n {e.Username}, te notificamos que la contrasena de tu cuenta PlusCorp ha sido cambiada. \n");
            Thread.Sleep(2000);
        }





        //Paso 1 Tarea

        // Paso 1: Creamos el delegate para el evento de mandar mail de verificacion
        public delegate void EmailSendEventHandler(object source, EmailSendEventArgs args);
        // Paso 2: Creamos el evento que se engatilla cuando se envia el mail de verifiacion
        public event EmailSendEventHandler EmailSent;

    }
}
