using System.Runtime.Serialization;

namespace SampleServiceLib
{
    [DataContract]
    public class Country
    {
        [DataMember]
        public string Name { get; set; }
    }
}