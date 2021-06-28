using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ClassTypes
{
    
    /*This is a documentation tag.*/
    public class TypesofConstructor : IPractice
    {
       
        // DummyClass dummy = new DummyClass();

        //TypesofConstructor obj = new TypesofConstructor();    

        /*This will cause a recursive call as firstly the default constructor is called in main method. 
         * Then it comes to this class level object creation which again cals the def. const which causes the program execution to be stuck in a recursive loop.        
         */
        int var1;

        //private TypesofConstructor() //Private constructor
        public TypesofConstructor() //Default constructor 
        {
            // Default or implicit constructor initializes all data members of the class with their default values.
            System.Console.WriteLine("In def const. \n" + this);
            var1 = 10;

        }
        TypesofConstructor(int param1) //Parameterized constructor
        {
            //Parameters to the constructor can be passed while creating the instance of the class.
            //It allows us to initialize each instance of a class with different values.

            int sum = param1 * 2;
            Console.WriteLine("Inside paramCtor: " + sum);

        }

        TypesofConstructor(TypesofConstructor obj) //Copy Constructor
        {
            //A parameterized constructor that takes the same class’s object as a parameter.
            //It copies the existing object’s value (which is passed as a parameter) to the newly created object instantiated by the constructor.


        }

        //static TypesofConstructor() //Static Constructor
        //{



        //}

        private TypesofConstructor(int var11, int var2)
        {

        }

        public void execute()
        {
            //Console.WriteLine(var1);
            // Console.WriteLine(obj.var1);
            //TypesofConstructor paramCtorObj = new TypesofConstructor(50);
            
            using (DummyClass dcObj = new DummyClass())
            {
                Console.WriteLine("Hahaha");
            }
            
        }


    }
}
