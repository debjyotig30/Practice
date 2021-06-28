using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Practice.ClassTypes
{
    public class CreateFile
    {
        public void Create(string fileName, string filePath, string fileContent)
        {

            filePath = String.Format("{0}//{1}.txt",filePath,fileName);

            Console.WriteLine(filePath);

            using FileStream fs = File.Create(filePath);
            {
                using var sr = new StreamWriter(fs);
                {
                    sr.WriteLine(fileContent);
                }
            }


            Console.WriteLine("done");
        }
    }
}
