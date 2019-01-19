using System.Runtime.Serialization;

namespace TestService
{
    [DataContract]
    public class Country
    {
        [DataMember]
        public string Name { get; set; }
    }
}