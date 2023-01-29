using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Enum
{
    public class StudentManager : IPractice
    {
        public Student Create(string name, int age, Gender sex, long studentId, string branch)
        {
            return new Student(name, age, sex, studentId, branch);

        }
        public void Print(Student student)
        {
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Age: " + student.Age);
            Console.WriteLine("Gender: " + student.Sex);
            Console.WriteLine("StudentId: " + student.StudentId);
            Console.WriteLine("Branch: " + student.Branch);
        }
        public void execute()
        {

            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.Write("Enter gender (male / female / unknown): ");
            string sex = Console.ReadLine();
            Gender gender = Gender.DoNotWishToDisclose;
            if ("male".Equals(sex.ToLower()))
                gender = Gender.Male;
            else if ("female".Equals(sex.ToLower()))
                gender = Gender.Female;
            Console.Write("Enter studentId: ");
            long studentId = long.Parse(Console.ReadLine());
            Console.Write("Enter branch: ");
            string branch = Console.ReadLine();
            Console.WriteLine("-----------------------");
            StudentManager studentManager = new StudentManager();
            Student studentObject = studentManager.Create(name, age, gender, studentId, branch);
            studentManager.Print(studentObject);
        }
    }
}
