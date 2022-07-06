using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Person
    {
        public Person(int inn, string name, string gender, string address)
        {
            Inn = inn;
            Name = name;
            Gender = gender;
            Address = address;
        }
        public static List<Person> person = new List<Person>();
        public static long Inn { get; set; }
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static string Gender { get; set; }
        public static string Address { get; set; }


    }
}
