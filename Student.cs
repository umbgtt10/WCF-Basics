using System.Runtime.Serialization;

namespace TestService
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Sid { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int M1 { get; set; }

        [DataMember]
        public int M2 { get; set; }

        [DataMember]
        public int M3 { get; set; }
    }
}
