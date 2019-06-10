using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C: \Users\Sahil Sehgal\Desktop\Sahil\testfile.txt";
            string Writetofilepath = @"C: \Users\Sahil Sehgal\Desktop\Sahil\testfile1.txt";           
            Payroll.FileProcess.WriteToFile(filepath, Writetofilepath);
        }
    }
}
