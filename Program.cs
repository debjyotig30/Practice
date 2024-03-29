﻿using Practice.Arrays;
using Practice.Pattern_Problems;
using Practice.Abstract_Class;
using System;
using Practice.Interface;
using Practice.InheritancePractice;
using Practice.Application;
using Practice.Keywords;
using Practice.ParameterTypes;
using Practice.ClassTypes;
using Practice.API_Testing;
using Practice.FileManagementSystem;
using Practice.GarbageCollection;
using Practice.Delegate;
using System.Collections.Generic;
using System.Collections;
using Practice.Generics;
using Practice.Operator_overloading;
using Practice.LINQ;
using System.Linq;
using Practice.Arrays;
using Practice.Enum;

namespace Practice
{
    public class PracticeCode
    {
        public static void myTry()
        {
            try
            {
                int a = 10;
                int b = 0;

                int x = a / b;
                Console.WriteLine("Done");
            }
            finally
            {
                Console.WriteLine("In Finally");
            }
        }
        public void test()
        {
            //char[] abcd = { 'a', 'b' };
            //string abcde = new string(abcd);

            Console.WriteLine("Added new Line");
            using (RandomPerson person1 = new RandomPerson())
            {

                person1.Name = "Bhola";
                person1.PrintName();

                RandomPerson person2 = new RandomPerson();
                person2.Name = "Shyam";
                person2.PrintName();

                int i = new int();
                i = 10;
                Console.WriteLine(i);
            }
        }

        public static void Main (string[] ars)
        {


            //IPractice arrObj = new ArraySort();
            //arrObj.execute();

            //return;

            //IPractice simObj = new Fibonacci();
            //simObj.execute();

            //return;

            //IPractice studentManager = new StudentManager();
            //studentManager.execute();

            //return;

            //IPractice linqObj = new LINQ_Main();
            //linqObj.execute();

            //return;

            //IPractice asObj = new ArraySort();
            //asObj.execute();

            //return;

            ////myTry();
            //try
            //{
            //    myTry();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Caught: " + e.Message);
            //    Console.WriteLine(e.StackTrace);
            //}
            //finally
            //{
            //    Console.WriteLine("Main FInally");
            //}
            //return;
            //// IPractice targetClass = new TargetClass();

            //IPractice poc = new Party_of_Couples();
            //poc.execute();




            //return;

            //IPractice calculator = new Calculator();
            //calculator.execute();
            //return;

            //Console.WriteLine("One thread for Main");
            //IPractice myThread = new MyThread();
            //myThread.execute();

            //return;

            //IPractice genericsTester = new GenericsTester<int>();
            //genericsTester.execute();

            //return;
            ////IPractice pn = new PrimeNumber();
            ////pn.execute();

            ////return;


            ////IPractice predicatetest = new PredicateTest();
            ////predicatetest.execute();

            ////return;
            ////int i,j;
            ////i = 20;

            ////double d1 = 100.23;
            ////double d2 = 100.84;
            ////i = (int)d1;
            ////j = (int)d2;
            ////Console.WriteLine(i);
            ////Console.WriteLine(j);

            ////int[] arr = new int[3];

            ////ArrayList mylist = new ArrayList();
            ////mylist.Add(1);
            ////mylist.Add(true);
            ////mylist.Add(1.23);
            ////mylist.Add('A');
            ////mylist.Add("Ball");

            ////List<int> genericList = new List<int>();

            ////return;

            //var hotelReception = new HotelReception();
            //hotelReception.execute();
            ////int j = 9;

            //return;

            //IPractice apiutilityobj1 = new APIUtility();
            //apiutilityobj1.execute();

            //return;

            //IPractice apiReader1 = new APIReader();
            //apiReader1.execute();

            //return;

            //PracticeCode p = new PracticeCode();
            //p.test();

            //GC.Collect();

            //RandomPerson random1 = new RandomPerson();
            //random1.Name = "Munna";
            //random1.PrintName();
            //random1.Dispose();

            //return;

            //SingletonClass singletonClass1 = SingletonClass.oldGetInstance();
            //singletonClass1.execute();
            //singletonClass1.MyString = "wow!!!";
            //singletonClass1.execute();

            //SingletonClass singletonClass2 = SingletonClass.oldGetInstance();
            //singletonClass2.execute();

            //return;

            ////StudentConstructor sctor = new StudentConstructor();
            ////StudentConstructor sctorpar = new StudentConstructor("name");
            ////StudentConstructor newVar1 = sctor.randomMethod();
            ////StudentConstructor newVar2 = sctor.randomMethod();

            //StudentConstructor varr = StudentConstructor.GetInstance();
            //varr.printName();

            //StudentConstructor varr1 = StudentConstructor.GetInstance();
            //varr1.printName();

            //StudentConstructor varr2 = StudentConstructor.GetInstance();
            //varr2.printName();



            ////sctor.printName();
            ////sctorpar.printName();
            ////newVar1.printName();
            ////newVar2.printName();

            //return;
            //IPractice typesofconstructor = new TypesofConstructor();
            //typesofconstructor.execute();

            //return;


            //IPractice filemanagementmainclass = new FileManagementMainClass();
            //filemanagementmainclass.execute();


            //return;

            //IPractice apiutilityobj = new APIUtility();
            //apiutilityobj.execute();

            //return;

            IPractice apiReader = new APIReader();
            apiReader.execute();

            return;

            //IPractice fileManagement = new FileManagement();
            //fileManagement.execute();

            //return;

            ////IPractice wrapperclass = new WrapperClass();
            ////wrapperclass.execute();

            //return;

            //IPractice parameterTest = new ParameterTest();
            //parameterTest.execute();

            //return;

            //IPractice testingVar = new TestingVar();
            //testingVar.execute();

            //return;

            //IPractice mainClass = new MainClass();
            //mainClass.execute();

            //IPractice inheritanceTester = new InheritanceTester();
            //inheritanceTester.execute();

            //*Testing Interfaces & Abstract Classes Starts*//

            MyChild myChild = new MyChild();
            MyImplementor myImplementor = new MyImplementor();

            MyParent myParent = myChild;
            MyInterface myInterface = myImplementor;

            myParent.doSomething();
            myParent.printStatus();
            myChild.doSomething();
            myChild.printStatus();
            myInterface.doSomething();
            myInterface.printStatus();
            //myImplementor.doSomething(); // Not Possible
            //myImplementor.printStatus(); // Not Possible
            myImplementor.randomAction();


            My2ndParent my2NdParent = new My2ndParent();
            my2NdParent.someMethod();

            Console.WriteLine("No. of arguments passed: " + ars.Length);
            Console.WriteLine("These arguments are: ");
            foreach (string ar in ars)
            {
                Console.WriteLine(ar);
            }
            try
            {
                int x = int.Parse(ars[0]);
                Console.WriteLine(x + 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something wrong happened...");
                Console.WriteLine(e.Message);
            }

            //*Testing Interfaces & Abstract Classes Ends*//

            //Interface testing starts.

            IHuman manBoy = new ManBoy();
            manBoy.execute();
            manBoy.getGender();
            manBoy.getSpecies();

            IHuman womanGirl = new WomanGirl();
            womanGirl.execute();
            womanGirl.getGender();
            womanGirl.getSpecies();

            IPractice manBoy1 = new ManBoy();
            manBoy1.execute();

            IPractice womanGirl1 = new WomanGirl();
            womanGirl1.execute();

            ManBoy manBoy2 = new ManBoy();
            manBoy2.execute();
            manBoy2.getGender();

            WomanGirl womanGirl2 = new WomanGirl();
            womanGirl2.execute();
            womanGirl2.getGender();

            //Interface testing ends.

            //Abstarct class testing starts.

            // AHuman ah = new AHuman(); //Abstract class - cannot be instantiated.

            //AHuman male = new Male();     //This calls execute from AHuman.
            IPractice male = new Male();    //This calls execute from Male.
            male.execute();

            Male male1 = new Male();
            male1.execute();            //This calls execute from Male.
            male1.getGender();
            male1.getSpecies();

            IPractice female = new Female();
            female.execute();

            Female female1 = new Female();
            female1.execute();

            //Abstarct class testing ends.

            IPractice primeNumber = new PrimeNumber();
            primeNumber.execute();

            IPractice fibonacci = new Fibonacci();
            fibonacci.execute();

            IPractice greatestElement = new GreatestElement();
            greatestElement.execute();

            IPractice starPatterns = new StarPatterns();
            starPatterns.execute();

        }
    }
}
