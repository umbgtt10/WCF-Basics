using System.Runtime.Serialization;

namespace MultiplicationServiceLibrary
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Sid { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember(IsRequired = true)]
        public string Contact { get; set; }
    }
}
