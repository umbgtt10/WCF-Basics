using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfStreamingLibrary
{
    [ServiceContract]
    public interface IStreamService
    {
        [OperationContract]
        Stream GetLargeObject();

        [OperationContract()]
        void UploadFile(ResponseFile request);

        [OperationContract]
        ResponseFile DownloadFile(RequestFile request);
    }
}
    
