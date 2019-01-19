using System.Runtime.Serialization;

namespace CoursesServiceLibrary
{
    [DataContract]
    public class Course
    {
        [DataMember]
        public int CourseId { get; set; }
        [DataMember]
        public string CourseName { get; set; }
    }
}
