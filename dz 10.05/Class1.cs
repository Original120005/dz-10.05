using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_10._05
{
    public abstract class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person() { }
        public Person(string n, int a) { name = n; age = a; }

        public abstract void Input(string n, int a, string ac);
    }

    namespace MyStudent
    {
        public class Student : Person
        {
            public string academy { get; set; }
            public Student(string n, int a, string ac) : base(n, a)
            {
                academy = ac;
            }

            public override void Input(string n, int a, string ac)
            {
                name = n;
                age = a;
                academy = ac;
            }

            public override string ToString()
            {
                return $"{name}   {age}   {academy}";
            }

        }
    }


}
