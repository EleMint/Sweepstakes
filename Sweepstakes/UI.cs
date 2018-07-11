using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Sweepstakes
{
    static class UI
    {
        public static string GetUserInformation(string message)
        {
            Console.Write(message);
            return Console.ReadLine().Trim();
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
        public static string GetUserString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().Trim();
        }
        public static void EmailSweepstakesWinner(Contestant Winner)
        {
            MailAddress fromAddress = new MailAddress("EleMintSweepstakes@gmail.com", "Dylan Schmidt");
            MailAddress toAddress = new MailAddress($"{Winner.email}", $"{Winner.firstName} {Winner.lastName}");
            string myPassword = "Schmidt16";
            string subject = "You've Won!";
            string body = $"Congratulations {Winner.firstName}, You've Won The Sweepstakes!";

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, myPassword)
            };
            using (MailMessage message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        public static int AskUserForInt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        public static ISweepstakesManager AskStyleofSweepstakesManager()
        {
            switch (UI.GetUserString("What Kind Of Manager Would You Like? (Stack or Queue)").ToLower())
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    return new SweepstakesQueueManager();
            }
        }
    }
}
