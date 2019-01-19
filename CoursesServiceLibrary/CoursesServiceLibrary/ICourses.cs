using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CoursesServiceLibrary
{
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface ICourses
    {
        [OperationContract(IsInitiating = true)]
        void AddToCourses(Course course);

        [OperationContract(IsTerminating = false)]
        List<Course> ListCourses();
    }
}
