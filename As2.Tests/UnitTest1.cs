using System.Runtime.CompilerServices;
using System;
using Xunit; 

namespace As2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Student_ToString_When_Student_Active()
        {   
            // Given
            Student student = new Student(19, "Lars", "Hansen");

            // When
            string expected = "Id: 19 Name: Lars Hansen StartDate: 31/12/2018 16.00.00 EndDate: 31/12/2021 14.00.00 GraduationDate: 31/12/2021 14.00.00 Status = Active";
            DateTime startDate = new DateTime(2018, 12, 31, 16, 0, 0); // 31/12/2018 16:00:00
            DateTime endDate = new DateTime(2021, 12, 31, 14, 0, 0); // 31/12/2020 20:00:00
            DateTime gradDate = new DateTime(2021, 12, 31, 14, 0, 0); // 24/09/2021 14:00:00
            student.StartDate = startDate;
            student.EndDate = endDate;
            student.GraduationDate = gradDate;
            string actual = student.ToString();

            // Then
            Assert.Equal(expected, actual);
        } 
        [Fact]
        public void Student_ToString_When_Student_New()
        {   
            // Given
            Student student = new Student(20, "Jens", "Jensen");

            // When
            string expected = "Id: 20 Name: Jens Jensen StartDate: 20/11/2021 11.00.00 EndDate: 31/12/2023 20.00.00 GraduationDate: 24/09/2023 14.00.00 Status = New";
            DateTime startDate = new DateTime(2021, 11, 20, 11, 0, 0); // 20/09/2021 11:00:00
            DateTime endDate = new DateTime(2023, 12, 31, 20, 0, 0); // 12/31/2023 20:00:00
            DateTime gradDate = new DateTime(2023, 09, 24, 14, 0, 0); // 09/24/2023 14:00:00
            student.StartDate = startDate;
            student.EndDate = endDate;
            student.GraduationDate = gradDate;
            string actual = student.ToString();

            // Then
            Assert.Equal(expected, actual);
        } 
        [Fact]
        public void Student_ToString_When_Student_Dropout()
        {   
            // Given
            Student student = new Student(18, "Theis", "Helt");

            // When
            string expected = "Id: 18 Name: Theis Helt StartDate: 31/12/2018 16.00.00 EndDate: 31/12/2020 20.00.00 GraduationDate: 24/09/2021 14.00.00 Status = Dropout";
            DateTime startDate = new DateTime(2018, 12, 31, 16, 0, 0); // 12/31/2018 16:00:00
            DateTime endDate = new DateTime(2020, 12, 31, 20, 0, 0); // 12/31/2020 20:00:00
            DateTime gradDate = new DateTime(2021, 09, 24, 14, 0, 0); // 09/24/2021 14:00:008
            student.StartDate = startDate;
            student.EndDate = endDate;
            student.GraduationDate = gradDate;
            string actual = student.ToString();

            // Then
            Assert.Equal(expected, actual);
        } 
        [Fact]
        public void Student_ToString_When_Student_Graduated()
        {   
            // Given
            Student student = new Student(19, "Andy", "Graduated");

            // When
            string expected = "Id: 19 Name: Andy Graduated StartDate: 31/12/2018 16.00.00 EndDate: 20/09/2021 12.00.00 GraduationDate: 20/09/2021 12.00.00 Status = Graduated";
            DateTime startDate = new DateTime(2018, 12, 31, 16, 0, 0); // 12/31/2018 16:00:00
            DateTime endDate = new DateTime(2021, 09, 20, 12, 0, 0); // 22/09/2022 12:00:00
            DateTime gradDate = new DateTime(2021, 09, 20, 12, 0, 0); // 24/09/2022 12:00:00
            student.StartDate = startDate;
            student.EndDate = endDate;
            student.GraduationDate = gradDate;
            string actual = student.ToString();

            // Then
            Assert.Equal(expected, actual);
        } 

        [Fact]
        public void ImmutableStudent_Equality_Functions_Correctly()
        {
        ImmutableStudent imstudent1 = new ImmutableStudent{
            Id = 26,
            GivenName = "Mikey",
            SurName = "Jakson",
            StartDate = new DateTime(2018, 06, 26),
            EndDate = new DateTime(2021, 05, 24),
            GraduationDate = new DateTime(2022, 06, 26)
        };
        ImmutableStudent imstudent2 = new ImmutableStudent{
            Id = 26,
            GivenName = "Mikey",
            SurName = "Jakson",
            StartDate = new DateTime(2018, 06, 26),
            EndDate = new DateTime(2021, 05, 24),
            GraduationDate = new DateTime(2022, 06, 26)
        };
        
        Assert.Equal(26, imstudent1.Id);
        Assert.Equal("Mikey", imstudent1.GivenName);
        Assert.Equal("Jakson", imstudent1.SurName);
        Assert.Equal(new DateTime(2018, 06, 26), imstudent1.StartDate);
        Assert.Equal(new DateTime(2021, 05, 24), imstudent1.EndDate);
        Assert.Equal(new DateTime(2022, 06, 26), imstudent1.GraduationDate);
        Assert.Equal(imstudent1, imstudent2);
        }
    }
}
