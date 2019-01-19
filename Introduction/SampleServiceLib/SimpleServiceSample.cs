using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleServiceLib
{
    public class SimpleServiceSample : ServiceSample
    {
        public List<Country> GetCountries()
        {
            return new List<Country>()
            {
                new Country() {Name = "Italy"},
                new Country() {Name = "Switzerland"},
                new Country() {Name = "China"},
                new Country() {Name = "Uk"},
                new Country() {Name = "USA"},
                new Country() {Name = "Argentina"}
            };
        }

        public string GetData()
        {
            return "This is a sample string";
        }

        public int GetMax(int[] ar)
        {
            return ar[0];
        }

        public string GetMessage(string Name)
        {
            return "Hallo Mr. " + Name;
        }

        public string GetResult(Student s)
        {
            double AVG = (s.M1 + s.M2 + s.M3)/3 ;

            return AVG > 10 ? "Umberto" : "Gotti";
        }

        public int[] GetSorted(int[] ar)
        {
            Array.Sort(ar);

            return ar;
        }

        public Student GetTopper(List<Student> ls)
        {
            return ls[0];
        }
    }
}
