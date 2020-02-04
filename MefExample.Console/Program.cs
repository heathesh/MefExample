using MefExample.Application.Implementation;

namespace MefExample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new Runner();
            runner.Run();
        }
    }
}
