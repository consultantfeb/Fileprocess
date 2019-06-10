using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class FileProcess
    {
        static string[] LineArray;

        public static bool CheckFileExist(string filePath)
        {
            return File.Exists(filePath);
        }

        public static string[] ReadFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        public static string ReadLines(string line)
        {
            line = line.Replace("\\n", "");
            line = line.Replace("\\r", "");
            return line;
        }

        public static void WriteToFile(string filePath, string WriteTextToFile)
        {
            string WriteText = null;
            if (CheckFileExist(filePath))
            {
                foreach (var Line in ReadFile(filePath))
                {
                    LineArray = ReadLines(Line).Split('\t');                    
                    if (Employee.CheckEmpDate(LineArray[2]))
                        WriteText += ReadLines(Line) + "\t" + Employee.CalculateSalary(Convert.ToDouble(LineArray[3])) + Environment.NewLine;
                    else
                        WriteText += ReadLines(Line) + "\t" + LineArray[3] + Environment.NewLine;
                }
            }
            System.IO.File.WriteAllText(WriteTextToFile, WriteText);
        }
    }
}
