using System.Runtime.CompilerServices;
using System;
using Xunit;

namespace As2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Student_ToString()
        {
            Student stud = new Student(13, "Lars", "Hansen");

            string expected = "Id: 13 Name: Lars Hansen Status: New";
            string actual = stud.ToString();

            Assert.Equal(expected, actual);
            
            // stud.GraduationDate = date1;
            // System.Console.WriteLine(stud.ToString());
        }
    }
}
