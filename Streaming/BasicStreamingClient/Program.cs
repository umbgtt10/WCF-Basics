using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicStreamingClient.WcfStreamingServiceReference;

namespace BasicStreamingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new StreamServiceClient();
            client.Open();

            using (FileStream fileStream = new FileStream("result.mp3", FileMode.Create))
            {
                client.GetLargeObject().CopyTo(fileStream);
            }

            Console.ReadKey();
            Console.WriteLine("Finished");
        }
    }
}
