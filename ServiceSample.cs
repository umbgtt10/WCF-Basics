using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    [ServiceContract]
    interface ServiceSample
    {
        [OperationContract]
        string GetData();

        [OperationContract]
        string GetMessage(string Name);

        [OperationContract]
        string GetResult(Student s);

        [OperationContract]
        int GetMax(int[] ar);

        [OperationContract]
        int[] GetSorted(int[] ar);

        [OperationContract]
        Student GetTopper(List<Student> ls);

        [OperationContract]
        List<Country> GetCountries();
    }
}
