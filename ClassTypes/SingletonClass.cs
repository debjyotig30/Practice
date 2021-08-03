using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ClassTypes
{
    /*-Can create only one object of this class.
      -Anyone can get that object.
      -It should be impossible to create more than one object.*/

    //Object creation is possible so cannot be static or abstract.
    //Only one object allowed so needs a counter.
    //Its public so anyone can access.
    public class SingletonClass
    {
        private static int counter = 0;
        private static SingletonClass singletonClassObject;
        public string MyString { get; set; }

        private SingletonClass()
        {
            MyString = "created";
        }

        public static SingletonClass GetInstance()
        {
            if (singletonClassObject == null)
            {
                singletonClassObject = new SingletonClass();
                
            }            
            return singletonClassObject;
        }

        public static SingletonClass oldGetInstance()
        {
            if(counter < 1)
            {
                SingletonClass singletonClassobj = new SingletonClass();
                singletonClassObject = singletonClassobj;
                counter++;
                return singletonClassObject;
            }
            else
            {
                return singletonClassObject;
            }
        }
        public void execute()
        {
            Console.WriteLine("Something Happened!!! - " + MyString);
        }

        // Property and its uses.
        //private string _myString;
        //public string myString {
        //    get
        //    {
        //        Console.WriteLine("Get is called.");
        //        return _myString;
        //    }
        //    set
        //    {
        //        Console.WriteLine("Set is called.");
        //        _myString = value;
        //    }
        //}

        //private string myString;
        //public string getMyString()
        //{
        //    return myString;
        //}
        //public void setMyString(string myString)
        //{
        //    this.myString = myString;
        //}


    }
}

/*
    Why/where do we use singleton calss?
    -Classes  that contain connection to external resources are generally created as singleton,
     so that we are maintaining only one copy of the connection across our application.
 */
