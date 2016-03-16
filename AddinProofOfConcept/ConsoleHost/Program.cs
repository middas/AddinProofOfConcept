using HostViewV2.V2;
using System;
using System.AddIn.Hosting;
using System.Collections.ObjectModel;

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
            string[] warnings = AddInStore.Rebuild(addInRoot);
            foreach (string warning in warnings)
            {
                Console.WriteLine(warning);
            }

            // Search for add-ins of type ICalculator (the host view of the add-in).
            Collection<AddInToken> tokens = AddInStore.FindAddIns(typeof(IV2), addInRoot);

            AddInToken token = null;
            if (tokens.Count > 1)
            {
                Console.WriteLine("Select a version:");

                for (int i = 0; i < tokens.Count; i++)
                {
                    Console.WriteLine("{0}: {1}", i, tokens[i].Name);
                }

                var key = Console.ReadKey();
                Console.WriteLine();

                if (key.KeyChar == '0')
                {
                    token = tokens[0];
                }
                else
                {
                    token = tokens[1];
                }
            }

            if (token != null)
            {
                // Activate the selected AddInToken in a new application domain
                // with the Internet trust level.
                IV2 v2 = token.Activate<IV2>(AddInSecurityLevel.Internet);
                v2.OnEvent += (sender, message) => { Console.WriteLine("Event Fired: {0}", message); };
                v2.Initialize(new CallbackHandler());

                // Run the add-in.
                v2.WriteToConsole("Hello World From Host!");
                Console.WriteLine(v2.GetName());

                //var test = (Stopwatch)v2.GetSource();

                //Task.Delay(500).Wait();

                //test.Stop();
                //Console.WriteLine(test.ElapsedTicks);
            }
        }

        private class CallbackHandler : ICallbackV2
        {
            public void DoWork()
            {
                Console.WriteLine("Successfully called DoWork()");
            }
        }
    }
}