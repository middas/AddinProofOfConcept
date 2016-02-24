using HostViewV2.V2;
using System;
using System.AddIn.Hosting;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConsoleHost
{
    internal class Program
    {
        private class CallbackHandler : ICallbackV2
        {
            public void DoWork()
            {
                Console.WriteLine("Successfully called DoWork()");
            }
        }

        private static void Main(string[] args)
        {
            // Assume that the current directory is the application folder,
            // and that it contains the pipeline folder structure.
            string addInRoot = Environment.CurrentDirectory + "\\Pipeline";

            // Update the cache files of the pipeline segments and add-ins.
            string[] warnings = AddInStore.Rebuild(addInRoot);
            foreach (string warning in warnings)
            {
                Console.WriteLine(warning);
            }

            // Search for add-ins of type ICalculator (the host view of the add-in).
            Collection<AddInToken> tokens = AddInStore.FindAddIns(typeof(IV2), addInRoot);

            // Ask the user which add-in they would like to use.
            AddInToken token = tokens.FirstOrDefault();

            // Activate the selected AddInToken in a new application domain
            // with the Internet trust level.
            IV2 v2 = token.Activate<IV2>(AddInSecurityLevel.Internet);
            v2.Initialize(new CallbackHandler());

            // Run the add-in.
            v2.WriteToConsole("Hello World!");
            Console.WriteLine(v2.GetName());
        }
    }
}