namespace MefExample.Application.Interface
{
    public interface IMessageSender
    {
        void Send(string message);

        string Name { get; }
    }
}
