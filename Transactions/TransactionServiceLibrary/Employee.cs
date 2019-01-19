using System.Runtime.Serialization;
namespace TransactionServiceLibrary
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Eid { get; set; }

        [DataMember]
        public string EName { get; set; }

        [DataMember]
        public double ESalary { get; set; }
    }
}
    	
    
