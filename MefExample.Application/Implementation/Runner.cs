using System.Collections.Generic;
using System.Composition;
using System.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Runtime.Loader;
using MefExample.Application.Interface;

namespace MefExample.Application.Implementation
{
    public class Runner
    {
        public void Run()
        {
            Compose();
            MessageSenders.FirstOrDefault(x => x.Name == "Email").Send("It will work, you will give me money");

            //foreach (var messageSenders in MessageSenders.FirstOrDefault(x => x.Name == "Email"))
            //{
            //    messageSenders.Send("Hello MEF");
            //}
        }

        [ImportMany]
        public IEnumerable<IMessageSender> MessageSenders { get; set; }

        private void Compose()
        {
            var path = @"D:\Temp\meftest";
            var assemblies = Directory
                .GetFiles(path, "*.dll", SearchOption.AllDirectories)
                .Select(AssemblyLoadContext.Default.LoadFromAssemblyPath)
                .ToList();
            var configuration = new ContainerConfiguration()
                .WithAssemblies(assemblies);
            using (var container = configuration.CreateContainer())
            {
                MessageSenders = container.GetExports<IMessageSender>();
            }
        }
    }
}
