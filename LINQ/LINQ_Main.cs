using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LINQ
{
    class LINQ_Main : IPractice
    {
        public static List<Employee> employees = new List<Employee>();
        public static List<Project> projects = new List<Project>();

        public static void InitializeEmployees()
        {
            employees.Add(new Employee
            {
                EmployeeId = 1,
                EmployeeName = "Tuba",
                ProjectId = 100
            });

            employees.Add(new Employee
            {
                EmployeeId = 2,
                EmployeeName = "Atul",
                ProjectId = 101
            });

            employees.Add(new Employee
            {
                EmployeeId = 3,
                EmployeeName = "Theran",
                ProjectId = 101
            });
        }

        public static void InitializeProjects()
        {
            projects.Add(new Project
            {
                ProjectId = 100,
                ProjectName = "ABC"

            });

            projects.Add(new Project
            {
                ProjectId = 101,
                ProjectName = "PQR"

            });
        }
       
        //public int?[] FindFirstNotNull(int?[] inputArray)
        //{
            //int?[] result = from num in inputArray
                            

            //return result;
        //}
        
        public void execute()
        {

            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };

            var res = from number in numbers
                      where number % 2 == 0
                      select number;

            foreach(var v in res)
            {
                Console.WriteLine("V:" + v);
            }            

            return;

            InitializeEmployees();
            InitializeProjects();

            #region LINQ using Query syntax.

            var querySyntax1 = from employee in employees
                               where employee.EmployeeName.StartsWith("T")
                               select employee.EmployeeName;

            Console.WriteLine("Where in querySyntax------");
            foreach (var item in querySyntax1)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region LINQ using Method syntax.

            var methodSyntax1 = employees.Where(e => e.EmployeeName.StartsWith("T"));
            Console.WriteLine("Where in methodSyntax-----");
            foreach (var item in methodSyntax1)
            {
                Console.WriteLine(item.EmployeeName);
            }

            Console.WriteLine('\n');
            #endregion

            //TAKE is used to select a particular no. of rows.
            //SKIP is used to skip a particular no. of rows.
            #region LINQ with array(of strings) & 'TAKE' & 'SKIP'

            string[] animals = { "Ant", "Bat", "Cat", "Dog", "Bat", "Cat" };
            string[] nums = { "1", "2", "3", "4", "5", "6" };

            var result = from animal in animals
                         where animal.StartsWith("A")
                         select animal;

            foreach (var animal in result)
            {
                Console.WriteLine("." + animal);
            }

            var newresult = (from animal in animals
                             orderby animal descending
                             select animal).Take(2);

            foreach (var animal in newresult)
            {
                Console.WriteLine("." + animal);
            }

            var newresult1 = (from animal in animals
                              orderby animal descending
                              select animal).Skip(2);

            Console.WriteLine("Skip: ");
            foreach (var animal in newresult1)
            {
                Console.WriteLine("." + animal);
            }
            #endregion

            #region LINQ with Dictionary
            Dictionary<int, string> My_dict1 = new Dictionary<int, string>() { { 1, "A" }, { 2, "B" } };

            My_dict1.Add(3, "C");
            My_dict1.Add(4, "D");
            My_dict1.Add(5, "E");

            var dictresult = from it in My_dict1
                             select it;

            foreach (var itr in dictresult)
            {
                Console.Write(itr.Key + " ");
                Console.WriteLine(itr.Value);
            }
            #endregion

            #region LINQ THEN BY
            var querySyntax4 = from employee in employees
                               orderby employee.ProjectId, employee.EmployeeName descending
                               select employee;

            var methodSyntax4 = employees.OrderBy(e => e.ProjectId).ThenByDescending(e => e.EmployeeName);

            Console.WriteLine("Then by in querySyntax------");
            foreach (var item in querySyntax4)
            {
                Console.WriteLine(item.EmployeeName + ":" + item.ProjectId);
            }

            Console.WriteLine("Then by in methodSyntax------");
            foreach (var item in methodSyntax4)
            {
                Console.WriteLine(item.EmployeeName + ":" + item.ProjectId);
            }

            Console.WriteLine('\n');
            #endregion

            #region LINQ GROUP BY
            var querySyntax7 = from employee in employees
                               group employee by employee.ProjectId;


            var methodSyntax7 = employees.GroupBy(e => e.ProjectId);

            Console.WriteLine("Group in querySyntax------");
            foreach (var item in querySyntax7)
            {
                Console.WriteLine(item.Key + ":" + item.Count());
            }

            Console.WriteLine("Group in methodSyntax------");
            foreach (var item in methodSyntax7)
            {
                Console.WriteLine(item.Key + ":" + item.Count());
            }

            Console.WriteLine('\n');
            #endregion

            #region LINQ FIRST
            var querySyntax8 = (from employee in employees
                                    //where employee.EmployeeName.StartsWith("Q")  
                                select employee).First();

            var methodSyntax8 = employees
                                //.Where(e => e.EmployeeName.StartsWith("Q"))                   
                                .First();

            Console.WriteLine("First in querySyntax------");
            if (querySyntax8 != null)
            {
                Console.WriteLine(querySyntax8.EmployeeName);
            }

            Console.WriteLine("First in methodSyntax------");
            if (methodSyntax8 != null)
            {
                Console.WriteLine(methodSyntax8.EmployeeName);
            }

            Console.WriteLine('\n');

            var firstwithArray = (from animal in animals
                                  select animal).First();

            //for(int i=0; i<firstwithArray.Length; i++)
            //{
            //    Console.WriteLine("LINQ first:" + firstwithArray[i]);
            //}

            Console.WriteLine("LINQ first: " + firstwithArray);
            #endregion

            #region LINQ FirstOrDefault 
            var querySyntax9 = (from employee in employees
                                    //where employee.EmployeeName.StartsWith("Q")  
                                select employee).FirstOrDefault();

            var methodSyntax9 = employees
                                //.Where(e => e.EmployeeName.StartsWith("Q"))  
                                .FirstOrDefault();

            Console.WriteLine("First or default in querySyntax------");
            if (querySyntax9 != null)
            {
                Console.WriteLine(querySyntax9.EmployeeName);
            }

            Console.WriteLine("First or default in methodSyntax------");
            if (methodSyntax9 != null)
            {
                Console.WriteLine(methodSyntax9.EmployeeName);
            }

            Console.WriteLine('\n');

            var firstordefaultwithArray = (from animal in animals
                                           select animal).FirstOrDefault();

            if (firstordefaultwithArray != null)
            {
                Console.WriteLine(firstordefaultwithArray);
            }

            #endregion

            #region LINQ JOIN
            var querySyntax10 = from employee in employees
                                join project in projects on employee.ProjectId equals project.ProjectId
                                select new { employee.EmployeeName, project.ProjectName };

            var methodSyntax10 = employees.Join(projects,
                                              e => e.ProjectId,
                                              p => p.ProjectId,
                                              (e, p) => new { e.EmployeeName, p.ProjectName });

            Console.WriteLine("Join in querySyntax------");
            foreach (var item in querySyntax10)
            {
                Console.WriteLine(item.EmployeeName + ":" + item.ProjectName);
            }

            Console.WriteLine('\n');

            Console.WriteLine("Join in methodSyntax------");
            foreach (var item in methodSyntax10)
            {
                Console.WriteLine(item.EmployeeName + ":" + item.ProjectName);
            }

            Console.WriteLine('\n');

            var multiSelect = from animal in animals
                               from num in nums
                               select new { animal, num }; //This will result in a cartesian join.

            Console.WriteLine("Multi:");
            Console.WriteLine(multiSelect);

            foreach (var itr in multiSelect)
            {
                Console.WriteLine(itr);
            }
            #endregion

            
        }
    }
}
