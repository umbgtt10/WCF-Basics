using System.ServiceModel;

namespace WcfStreamingLibrary
{
    [MessageContract]
    public class RequestFile
    {
        [MessageBodyMember]
        public string FileName;

        [MessageBodyMember]
        public long ByteStart = 0;
    }
}