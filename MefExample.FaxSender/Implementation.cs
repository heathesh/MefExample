using MefExample.Application.Interface;
using System;
using System.Composition;

namespace MefExample.FaxSender
{
    [Export(typeof(IMessageSender))]
    public class Implementation : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"FAX Sender: {message} It works Richmond.");
        }

        public string Name => "Fax";
    }
}
