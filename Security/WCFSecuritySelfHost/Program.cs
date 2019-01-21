using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WCFSecurityLibrary;

namespace MEPInWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri netTcpBaseAddress = new Uri("net.tcp://localhost:909/");

            ServiceHost Sh = new ServiceHost(typeof(Calculator), new Uri[] { netTcpBaseAddress });

            var netTcpBinding = new NetTcpBinding();
            netTcpBinding.Security.Mode = SecurityMode.Message;
            //netTcpBinding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
            ServiceEndpoint Se = Sh.AddServiceEndpoint(typeof(ICalculator), netTcpBinding, netTcpBaseAddress);

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            Sh.Description.Behaviors.Add(smb);

            ServiceEndpoint tcpSeMex = Sh.AddServiceEndpoint(typeof(IMetadataExchange),
                                                             MetadataExchangeBindings.CreateMexTcpBinding(),
                                                             "net.tcp://localhost:909/mex");

            Sh.Open();

            Console.WriteLine("Started.....");

            foreach (var item in Sh.Description.Endpoints)
            {
                Console.WriteLine("Address: " + item.Address.ToString());
                Console.WriteLine("Binding: " + item.Binding.Name.ToString());
                Console.WriteLine("Contract: " + item.Contract.Name.ToString());
            }

            Console.ReadLine();

            Sh.Close();
        }
    }
}
