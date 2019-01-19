using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MultiplicationServiceLibrary
{
    public class DivisionFault
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string OperationMessage { get; set; }
    }

    [ServiceContract]
    public interface MultiplicationService
    {
        [OperationContract]
        int MultiplyInt(int a, int b);

        [OperationContract]
        [FaultContract(typeof(DivisionFault))]
        int DivideInt(int a, int b);

        [OperationContract]
        double MultiplyDouble(double a, double b);

        [OperationContract]
        void Save(Student s);
    }
}
