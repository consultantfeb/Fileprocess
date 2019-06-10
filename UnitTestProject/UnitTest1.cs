using System;
using Payroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void CheckEmpDate_DateofjoiningLessthanCurrentYr_ReturnTrue()
        {
            //Arrange
            var Employee = new Employee();
            //Act
            var result= Employee.CheckEmpDate("12/07/2017");
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CalculateSalary_Salary_ReturnSalary()
        {
            //Arrange
            var Employee = new Employee();
            //Act
            var result = Employee.CalculateSalary(30000);
            //Assert
            Assert.AreEqual(33000,result);
        }
    }

    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void CheckFileExist_FilePath_ReturnTrue()
        {
            //Arrange
            var FileProcess = new FileProcess();
            string filepath = @"C: \Users\Sahil Sehgal\Desktop\Sahil\testfile.txt";
            //Act
            var result = FileProcess.CheckFileExist(filepath);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ReadFile_FilePath_ReturnString()
        {
            //Arrange
            var FileProcess = new FileProcess();
            string filepath = @"C: \Users\Sahil Sehgal\Desktop\Sahil\testfile.txt";
            //Act
            var result = FileProcess.ReadFile(filepath);
            var result1 = File.ReadAllLines(filepath);
            //Assert
            CollectionAssert.AreEqual(result1, result);
        }
        [TestMethod]
        public void ReadLines_Line_ReturnLine()
        {
            //Arrange
            var FileProcess = new FileProcess();
            string textfile = null;
            string filepath = @"C: \Users\Sahil Sehgal\Desktop\Sahil\testfile.txt";
            //Act
            foreach (var Line in FileProcess.ReadFile(filepath))
            {
                textfile += FileProcess.ReadLines(Line) + Environment.NewLine;                
                
            }
            string text = File.ReadAllText(filepath);
            //Assert
            Assert.AreEqual(text, textfile);
        }
    }
}
