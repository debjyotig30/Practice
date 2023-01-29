using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Enum
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }
        public long StudentId{ get; set; }
        public string Branch { get; set; }

        public Student()
        {
        }

        public Student(string name, int age, Gender sex, long studentId, string branch)
        {
            Name = name;
            Age = age;
            Sex = sex;
            StudentId = studentId;
            Branch = branch;

        }
    }
}
