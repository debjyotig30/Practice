using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ClassTypes
{
    class FileManagement: CreateFile, IPractice
    {
        
        public void execute()
        {
            CreateFile createFile = new CreateFile();
            string fileName = "Test.txt";
            string filePath = "D:\\";
            string fileContent = "This is a test file";
            createFile.Create(fileName, filePath, fileContent);
        }
    }
}
