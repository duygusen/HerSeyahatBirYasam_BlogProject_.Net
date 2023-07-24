using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MimeKit;

namespace Project.Helpers;

public class MailHelper
{
    public static bool SendEmail(string mesaj, string konu = "Yeni bir mesaj var!")
    {
        var emailMessage = new MimeMessage();
        emailMessage.From.Add(new MailboxAddress("Duygu Sen", "seenduygu@gmail.com")); //orhan@mailer.akademiprojeler.live
        emailMessage.To.Add(new MailboxAddress("Duygu", "duygu_sen_10@hotmail.com"));
        emailMessage.Subject="Duygu Blog - " + konu;
        
        var builder = new BodyBuilder();

        //builder.HtmlBody = mesaj;
        
        // builder.HtmlBody = $@"
        //     Gönderen Ad Soyad: {model.AdSoyad}<br>
        //     Gönderen E-posta: {model.EpostaAdresi}<br>
        //     Konu: {model.Konu}<br>
        //     Mesaj: {model.Mesaj}";

        builder.HtmlBody = $@"<!DOCTYPE html>
            <html lang=""tr"">
            <head><meta charset = ""UTF-8"" ><meta http - equiv = ""X-UA-Compatible"" content = ""IE=edge"">
            <meta name = ""viewport"" content = ""width=device-width, initial-scale=1.0"">
            <title > E-Posta </title>
            </head>
            <body style = ""background-color: #cccccc; padding:20px"">
            <table style = ""border:0; width:100%; background-color: #ffffff; padding: 30px;"">
            <tr><td style = ""font-family: Arial;"" >{mesaj}</td></tr>
            </table>
            </body>
            </html>";

        emailMessage.Body = builder.ToMessageBody();

        try
        {
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.ey.mailgun.org", 587, SecureSocketOptions.StartTls);
                smtpClient.Authenticate("postmaster@mailer.akademiprojeler.live",
                    "9eac1c6725827d72db7e731f5d83d0b2-af778b4b-08044919");
                smtpClient.Send(emailMessage);
                smtpClient.Disconnect(true);
            }

            return true;
        }
        catch
        {
            return false;
        }

    }
}

