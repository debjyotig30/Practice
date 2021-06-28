using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.FileManagementSystem
{
    class FileManagementMainClass : FileWriter, IPractice
    {
        public void execute()
        {
            //FileReader fileReader = new FileReader();
            //fileReader.ReadTextFile();

            FileWriter fileWriter = new FileWriter();
            string fileName = "NotSure";
            string filePath = null;
            string fileContent = "I am really not sure!";
            fileWriter.CreateTextFile(fileName, filePath, fileContent);
        }
    }
}
