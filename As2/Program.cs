using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace As2
{
    public class Program{
        public static void Main(string[] args){}
    }
    public class Student
    {
        public int Id {get;}
        public string GivenName{get;}
        public string SurName{get;}
        public Status Status{
            get {
                if (StartDate.CompareTo(DateTime.Now) > 0 && (StartDate - DateTime.Now).TotalDays <= 90){
                    return Status.New;
                } else if (EndDate.CompareTo(DateTime.Now) > 0 && GraduationDate.CompareTo(DateTime.Now) > 0) {
                    return Status.Active;
                } else if (EndDate.CompareTo(GraduationDate) < 0) {
                    return Status.Dropout;
                } else {
                    return Status.Graduated;
                }
            
             }
        }
        public DateTime StartDate{get; set;}
        public DateTime EndDate{get; set;}
        public DateTime GraduationDate{get; set;}

        public Student(int id, string givenName, string surName) {
            Id = id;
            GivenName = givenName;
            SurName = surName;
        }

        public override string ToString() => ("Id: " + Id + " Name: " + GivenName + " " + SurName + " StartDate: " + StartDate + " EndDate: " + EndDate + " GraduationDate: " + GraduationDate + " Status = " + Status);
        }
    

    public record ImmutableStudent
    {
        public int Id{get; init;}
        public string GivenName{get; init;}
        public string SurName{get; init;}
        public Status Status{
            get {
                if (StartDate.CompareTo(DateTime.Now) > 0 && (StartDate - DateTime.Now).TotalDays <= 90){
                    return Status.New;
                } else if (EndDate.CompareTo(DateTime.Now) > 0 && GraduationDate.CompareTo(DateTime.Now) > 0) {
                    return Status.Active;
                } else if (EndDate.CompareTo(GraduationDate) < 0) {
                    return Status.Dropout;
                } else {
                    return Status.Graduated;
                }
            
             }
        }
        public DateTime StartDate{get; init;}
        public DateTime EndDate{get; init;}
        public DateTime GraduationDate{get; init;}

        public override string ToString() => ("Id: " + Id + " Name: " + GivenName + " " + SurName + " StartDate: " + StartDate + " EndDate: " + EndDate + " GraduationDate: " + GraduationDate + " Status = " + Status);
    }

    public enum Status
    {
        New, Active, Dropout, Graduated
    }

    
}


