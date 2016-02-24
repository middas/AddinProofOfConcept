using HostView;
using System;
using System.AddIn.Hosting;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConsoleHost
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Assume that the current directory is the application folder,
            // and that it contains the pipeline folder structure.
            string addInRoot = Environment.CurrentDirectory + "\\Pipeline";

            // Update the cache files of the pipeline segments and add-ins.
            string[] warnings = AddInStore.Update(addInRoot);
            foreach (string warning in warnings)
            {
                Console.WriteLine(warning);
            }

            // Search for add-ins of type ICalculator (the host view of the add-in).
            Collection<AddInToken> tokens = AddInStore.FindAddIns(typeof(IV1), addInRoot);

            // Ask the user which add-in they would like to use.
            AddInToken token = tokens.FirstOrDefault();

            // Activate the selected AddInToken in a new application domain
            // with the Internet trust level.
            IV1 v1 = token.Activate<IV1>(AddInSecurityLevel.Internet);

            // Run the add-in.
            v1.WriteToConsole();
            Console.WriteLine(v1.GetName());
        }
    }
}