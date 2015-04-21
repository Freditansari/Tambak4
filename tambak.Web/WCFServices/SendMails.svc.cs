using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace tambak.Web.WCFServices
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SendMails
    {
      
        String ServerName = "smtpout.asia.secureserver.net";
        String SystemEmails = "system@cendanaholding.com";
        int PortAddress = 3535;

        string UserName = "system@cendanaholding.com";
        string Password = "I;bB}(pQvA)N";
      
      


        [OperationContract]
        public string SendEmail(String toAddress, string Subjects, string EmailBody)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(ServerName);

                mail.From = new MailAddress(SystemEmails);
                mail.To.Add(toAddress);
                mail.Subject = Subjects;
                mail.Body = EmailBody;
                mail.IsBodyHtml = true;

                SmtpServer.Port = PortAddress;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.ServicePoint.MaxIdleTime = 1;
                SmtpServer.Credentials = new System.Net.NetworkCredential(UserName, Password);
                SmtpServer.Timeout = 10000;
                
                //SmtpServer.EnableSsl = true;
                //SmtpServer.EnableSsl = false;
               

                SmtpServer.Send(mail);
                //MessageBox.Show("mail Send");
                return "ok";
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return ex.Message;
            }
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
