using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace appLaboratorioMedico.Utilities
{
    class Email
    {
        private static MailMessage correo;
        private static Attachment dato;
        private static StringBuilder mensaje = new StringBuilder();
        private static string asunto;

        public static bool Enviar(string pPara, string pNombreCliente, string pUbicacionAttachment)
        {
            bool correcto = true;

            // mensaje            
            mensaje.AppendFormat("Dear: ");
            mensaje.AppendFormat(pNombreCliente);
            mensaje.AppendFormat("\n\nAttached here you will find information about you order in Magic Book Store.");
            mensaje.AppendFormat("\n\nThank you for your order.");

            // Asunto
            asunto = "Magic Book Store Order";

            try
            {

                correo = new MailMessage();
                correo.To.Add(new MailAddress(pPara));
                // Persona que va a enviar el mensaje
                correo.From = new MailAddress("maickher@hotmail.com");
                // Establecer el asunto del mensaje
                correo.Subject = asunto;
                // Establer el cuerpo del mensaje
                correo.Body = mensaje.ToString();
                correo.IsBodyHtml = false;

                if (!string.IsNullOrEmpty(pUbicacionAttachment))
                {
                    dato = new Attachment(pUbicacionAttachment, MediaTypeNames.Application.Octet);
                    correo.Attachments.Add(dato);
                }

                SmtpClient cliente = new SmtpClient("smtp.live.com", 587);
                using (cliente)
                {
                    cliente.Credentials = new System.Net.NetworkCredential("maickher@hotmail.com", "707mickey");
                    cliente.EnableSsl = true;
                    cliente.Send(correo);
                }
            }
            catch (Exception)
            {
                correcto = false;                
            }

            return correcto;
        }
        
    }
}
