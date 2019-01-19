using System;
using System.Runtime.Serialization;
namespace TransactionServiceLibrary
{
    [DataContract]
    public class SalaryHistory
    {
        [DataMember]
        public int SNo { get; set; }

        [DataMember]
        public int Eid { get; set; }

        [DataMember]
        public double ESalary { get; set; }

        [DataMember]
        public DateTime StDate { get; set; }

        [DataMember]
        public DateTime? EdDate { get; set; }

    }
}
    	
    
