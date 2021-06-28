using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ClassTypes
{
    //Private class is not possible.
    class StudentConstructor //This class is not public, hence can be accessed within classes of same namespace.
    {
        string studentName;
        static int counter;
        private StudentConstructor() : this("Default") //We use ':' to call a constructor from another constructor.
        {
            Console.WriteLine("Default Constructor...");
        }

        private StudentConstructor(string name)
        {
            /*Both are same. 'this' is used to access instance members.
             * The 'studentName' variable belongs to an object of StudentConstructor class.
             * Why? Because the default constructor is already there which has already initialized an object.
             * So this variable belongs to that object.
             * Anyways, anything that is not static is instance i.e belongs to an object. Staic things belong to a class.
             */
            this.studentName = name;
            //studentName = name;

            Console.WriteLine("Parameterized Constructor...");
        }

        public static StudentConstructor GetInstance()
        {
            Guid guid = Guid.NewGuid();
            
            if(counter < 2)
            {
                StudentConstructor studobj = new StudentConstructor(guid.ToString());
                counter++;
                return studobj;
            }
            else
            {
                return null;
            }
            
        }

        public void printName()
        {
            Console.WriteLine(studentName);
        }


    }
}
