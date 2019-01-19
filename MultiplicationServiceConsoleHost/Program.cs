using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiplicationServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpBaseAddress = new Uri("http://localhost:6790/MyHttpEndpoint");

            var host = new ServiceHost((typeof(SimpleMultiplicationService)), httpBaseAddress);

            var binding = new BasicHttpBinding();
            binding.OpenTimeout = new TimeSpan(0, 10, 0);
            binding.CloseTimeout = new TimeSpan(0, 10, 0);

            ServiceEndpoint httpEndpoint =
                host.AddServiceEndpoint(typeof(MultiplicationService), binding, httpBaseAddress);

            var behaviour = new ServiceMetadataBehavior();
            behaviour.HttpGetEnabled = true;
            host.Description.Behaviors.Add(behaviour);

            host.Open();

            Console.WriteLine("Started...");

            foreach (var endpoint in host.Description.Endpoints)
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($"Address: {endpoint.Address}");
                Console.WriteLine($"Binding: {endpoint.Binding.Name}");
                Console.WriteLine($"Contract: {endpoint.Contract.ContractType}");
                Console.WriteLine($"OpenTimeOut: {endpoint.Binding.OpenTimeout}");
                Console.WriteLine($"CloseTimeOut: {endpoint.Binding.CloseTimeout}");
            }

            Console.ReadKey();

            host.Close();
        }
    }
}

