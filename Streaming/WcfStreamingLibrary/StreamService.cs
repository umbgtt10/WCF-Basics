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

        public ResponseFile DownloadFile(RequestFile request)
        {
            ResponseFile result = new ResponseFile();

            FileStream stream = GetFileStream(Path.GetFullPath(request.FileName));
            stream.Seek(request.ByteStart, SeekOrigin.Begin);
            result.FileName = request.FileName;
            result.Length = stream.Length;
            result.FileByteStream = stream;
            return result;

        }

        private FileStream GetFileStream(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            if (!fileInfo.Exists)
                throw new FileNotFoundException("File not found");

            return new FileStream(filePath, FileMode.Open, FileAccess.Read);
        }

        public void UploadFile(ResponseFile request)
        {

            string filePath = Path.GetFullPath(request.FileName);

            int chunkSize = 2048;
            byte[] buffer = new byte[chunkSize];

            using (FileStream stream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                do
                {
                    var readbyte = request.FileByteStream.Read(buffer, 0, chunkSize);
                    if (readbyte == 0) break;

                    stream.Write(buffer, 0, readbyte);
                } while (true);
                stream.Close();
            }
        }
    }
}