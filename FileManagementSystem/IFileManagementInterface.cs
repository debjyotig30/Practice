using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.FileManagementSystem
{
    public interface IFileManagementInterface
    {
        public void CreateTextFile(string fileName, string filePath, string fileContent);
        
        public void CreateTextFile(string fileName, string fileContent);

        public void ReadTextFile(string fileName, string filePath, string fileContent);
        
        public void ReadTextFile(string fileName, string fileContent);
    }
}
