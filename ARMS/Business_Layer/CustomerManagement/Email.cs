using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace Business_Layer
{
    public class Email
    {
        public Email()
        {
 
        }

        public void SendGEmail(string mailaddress, string topic, string text)
        {
            //string temp;
            try
            {              
                string sourceMailAdress = "zongmingzou@gmail.com";
                //string destinationMailAdress = "zongmingzou@gmail.com";

                string destinationMailAdress = mailaddress;
                //PrintScreen();

                MailMessage Message = new MailMessage(sourceMailAdress, destinationMailAdress);

                Message.Subject = topic;
                Message.Body = text;
                //Message1.Attachments.Add(new Attachment("C:\\printscreen.jpg"));
                //File.Delete(@"C:\printscreen.jpg");
                Message.Priority = MailPriority.Normal;


                SmtpClient mailSender = new SmtpClient("smtp.gmail.com", 587);      //or 465 
                mailSender.EnableSsl = true;
                mailSender.Credentials = new System.Net.NetworkCredential("zongmingzou@gmail.com", "zou881027");
                //mailSender.UseDefaultCredentials = true;

                mailSender.Send(Message);

                Message.Dispose();
            }
            catch(Exception ex)
            {
                throw new ArgumentException("Error with SMTP: " + ex.Message);     
                //temp = "Error with SMTP: " + ex.Message;
            }
        }
    }
}
