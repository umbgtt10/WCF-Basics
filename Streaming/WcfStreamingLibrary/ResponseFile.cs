using System;
using System.IO;
using System.ServiceModel;

namespace WcfStreamingLibrary
{
    [MessageContract]
    public class ResponseFile : IDisposable
    {
        [MessageHeader]
        public string FileName;

        [MessageHeader]
        public long Length;

        [MessageBodyMember]
        public Stream FileByteStream;

        [MessageHeader]
        public long ByteStart = 0;

        public void Dispose()
        {
            if (FileByteStream != null)
            {
                FileByteStream.Close();
                FileByteStream = null;
            }
        }
    }
}