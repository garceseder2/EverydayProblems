using System.Reflection;
namespace Life.Integration;

using GemBox.Email;
using GemBox.Email.Pop;
using Life.Models;
///
public class Mail
{
    public static void GetEmails(){
        
        try
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            using (PopClient pop = new PopClient("outlook.office365.com"))
            {
            // Connect and login.
            pop.Connect();
            Console.WriteLine("Connected.");

            pop.Authenticate("garceseder2@outlook.com", "Mneeygp02.o");
            Console.WriteLine("Authenticated.");

            // Check if there are any messages available on the server.
            if (pop.GetCount() == 0)
                return;

            // Download message with sequence number 1 (the first message).
            MailMessage message = pop.GetMessage(1);

            // Display message sender and subject.
            Console.WriteLine();
            Console.WriteLine($"From: {message.From}");
            Console.WriteLine($"Subject: {message.Subject}");

            // Display message body.
            Console.WriteLine("Body:");
            
            string bodyHtml = String.IsNullOrEmpty(message.BodyHtml) ? "": message.BodyHtml;
            string bodyText = String.IsNullOrEmpty(message.BodyText) ? "": message.BodyText;
            string body = String.IsNullOrEmpty(bodyHtml) ? bodyText : bodyHtml;
            Console.WriteLine(body);
            }
        }
        catch (System.Exception)
        {   
            throw;
        }
    }
}
