using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace As2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Student stud = new Student(13, "d", "f");
            // DateTime date1 = new DateTime(2015, 12, 25);
            // stud.GraduationDate = date1;
            // System.Console.WriteLine(stud.ToString());
        }
    }

    public class Student
    {
        public int Id {get;}
        public string GivenName{get;}
        public string SurName{get;}
        public Status Status{get;}
        public DateTime StartDate;
        public DateTime EndDate;
        public DateTime GraduationDate{get; set;}

        public Student(int id, string givenName, string surName) {
            Id = id;
            GivenName = givenName;
            SurName = surName;
        }

        public override string ToString() => ("Id: " + Id + " Name: " + GivenName + " " + SurName + " Status: " + Status);
    }

    public class ImmutableStudent
    {
        public int Id{get; init;}
        public string GivenName{get; init;}
        public string Surname{get; init;}
        public Status Status{get; init;}
        public DateTime StartDate{get; init;}
        public DateTime EndDate{get; init;}
        public DateTime GraduationDate{get; init;}

        public string ToString() => ("Id: " + Id + " Name: " + GivenName + " " + Surname + " Status: " + Status);
    }

    public enum Status
    {
        New, Active, Dropout, Graduated
    }
}
