using System;
using System.IO;
using System.ServiceModel;

namespace WcfStreamingLibrary
{
    [ServiceBehavior]
    public class StreamService : IStreamService
    {
        public Stream GetLargeObject()
        {
            // Add path to a big file, this one is 2.5 gb
            string filePath = @"F:\Videos\Films\Adventure\8MM [1999] [ENG].avi";

            try
            {
               FileStream imageFile = File.OpenRead(filePath);
               return imageFile;
            }
            catch (IOException ex)
            {
                Console.WriteLine(String.Format("An exception was thrown while trying to open file {0}", filePath));
                Console.WriteLine("Exception is: ");
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}