using System;
using System.IO;

namespace Practice.FileManagementSystem
{
    class FileWriter : IFileManagementInterface
    {
        public void CreateTextFile(string fileName, string filePath, string fileContent)
        {
            filePath = String.Format("{0}//{1}.txt", filePath, fileName);

            Console.WriteLine(filePath);

            using FileStream fs = File.Create(filePath);
            {
                using var sr = new StreamWriter(fs);
                {
                    sr.WriteLine(fileContent);
                }
            }
        }

        public void CreateTextFile(string fileName, string fileContent)
        {
            string deffilepath = @"D:\\";
            string filePath = deffilepath;

            Console.WriteLine(filePath);

            using FileStream fs = File.Create(filePath);
            {
                using var sr = new StreamWriter(fs);
                {
                    sr.WriteLine(fileContent);
                }
            }
        }

        public void ReadTextFile(string fileName, string filePath, string fileContent)
        {
            throw new NotImplementedException();
        }

        public void ReadTextFile(string fileName, string fileContent)
        {
            throw new NotImplementedException();
        }
    }
}
