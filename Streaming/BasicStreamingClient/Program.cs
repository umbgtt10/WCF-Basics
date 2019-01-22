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
        private static void DownloadSync()
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

        static void Main(string[] args)
        {
            StartDownloading();

            Console.WriteLine("Finished");
            Console.ReadKey();            
        }

        public static void StartDownloading()
        {
            var client = new StreamServiceClient();
            client.Open();

            try
            {
                string fileName = @"F:\Videos\Films\Adventure\8MM [1999] [ENG].avi";

                Stream inputStream;
                long byteStart = 0;

                long length = client.DownloadFile(ref byteStart, ref fileName, out inputStream);

                using (FileStream writeStream = new System.IO.FileStream(@"8MM [1999] [ENG].avi", FileMode.OpenOrCreate, FileAccess.Write))
                {

                    int chunkSize = 2048;
                    byte[] buffer = new byte[chunkSize];

                    do
                    {
                        int bytesRead = inputStream.Read(buffer, 0, chunkSize);
                        if (bytesRead == 0) break;


                        writeStream.Write(buffer, 0, bytesRead);
                    }
                    while (true);

                    writeStream.Close();
                }
                inputStream.Dispose();
            }
            catch
            {
            }
        }
    }
}
