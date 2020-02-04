using System;
using System.Composition;
using MefExample.Application.Interface;

namespace MefExample.EmailSender
{
    [Export(typeof(IMessageSender))]
    public class Implementation : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email Sender: {message}");
        }

        public string Name => "Email";
    }
}
