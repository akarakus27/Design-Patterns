using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.MessageSenderbase = new EmailSender();
            customerManager.UpdateCustomer();
            Console.ReadLine();
        }
    }
    abstract class MessageSenderbase
    {
        public void Save()
        {
            Console.WriteLine("Message saved!");
        }
        public abstract void Send(Body body);
        
    }

      class Body
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }

    class SmsSender : MessageSenderbase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via MailSender ",body.Title);
        }
    }
    class EmailSender : MessageSenderbase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via EMailSender ", body.Title);
        }
       
    }
    class CustomerManager
    {
        public MessageSenderbase MessageSenderbase { get; set; }
        public void UpdateCustomer()
        {
            MessageSenderbase.Send(new Body { Title = "About the course !"});
            Console.WriteLine("Customer uptated");
        }
    }
     



}
