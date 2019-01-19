using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MultiplicationServiceLibrary
{
    [ServiceContract]
    public interface MultiplicationService
    {
        [OperationContract]
        int Multiply(int a, int b);
    }
}
