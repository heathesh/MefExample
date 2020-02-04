using System;
using System.Composition;
using MefExample.Application.Interface;

namespace MefExample.SmsSender
{
    [Export(typeof(IMessageSender))]
    public class Implementation : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS Sender: {message}");
        }

        public string Name => "Sms";
    }
}
