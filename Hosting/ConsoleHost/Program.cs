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
            var tcpBaseAddress = new Uri("net.tcp://localhost:6789/MyTcpEndpoint");
            var httpBaseAddress = new Uri("http://localhost:6790/MyHttpEndpoint");
            var httpMexBaseAddress = new Uri("http://localhost:6790/MyHttpEndpoint/mex");
            var tcpMexBaseAddress = new Uri("net.tcp://localhost:6789/MyTcpEndpoint/mex");

            var host = new ServiceHost((typeof(SimpleMultiplicationService)), new [] {tcpBaseAddress, httpBaseAddress});

            ServiceEndpoint tcpEndpoint = host.AddServiceEndpoint(typeof(MultiplicationService), new NetTcpBinding(), tcpBaseAddress);
            ServiceEndpoint httpEndpoint = host.AddServiceEndpoint(typeof(MultiplicationService), new BasicHttpBinding(), httpBaseAddress);

            /*
            var behaviour = new ServiceMetadataBehavior();
            behaviour.HttpGetEnabled = false;
            host.Description.Behaviors.Add(behaviour);
            */


            var httpMex = host.AddServiceEndpoint(
                typeof(IMetadataExchange),
                MetadataExchangeBindings.CreateMexHttpBinding(), 
                httpMexBaseAddress);

            var htcpMex = host.AddServiceEndpoint(
                typeof(IMetadataExchange),
                MetadataExchangeBindings.CreateMexTcpBinding(),
                tcpMexBaseAddress);

            host.Open();

            Console.WriteLine("Started...");

            foreach (var endpoint in host.Description.Endpoints)
            {
                Console.WriteLine($"Address: {endpoint.Address}");
                Console.WriteLine($"Binding: {endpoint.Binding.Name}");
                Console.WriteLine($"Contract: {endpoint.Contract.ContractType}");
            }

            Console.ReadKey();

            host.Close();
        }
    }
}

