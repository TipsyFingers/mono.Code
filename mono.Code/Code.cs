using System.Collections.Generic;
using System.Text.RegularExpressions;


//Project.Code – ClassLibrary project – core business logic of your application (must be referenced into ConsoleApplication project)  

namespace mono.Code
{
    public static class Operations
    {
        public static string op1 = "enlist";
        public static string op2 = "display";
    }

    public abstract class Person
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
    }

    public class Student : Person
    {
        public decimal GPA { get; set; }

        public Student(int id, string fname, string lname, decimal gpa)
        {
            this.Id = id;
            this.FName = fname;
            this.LName = lname;
            this.GPA = gpa;
        }
    }

    public class StudentIdGenerator                                         // najjednostavniji oblik generiranja ID-a
    {
        public static int GetID()
        {
            int id = StudentContainer.Students.Count;
            return id;
        }
    }

    public class ValidationClass
    {

        public static bool validateString(string valStr)                    // provjera sadržava li string samo slova (ukljucujuci internacionalne znakove)
        {
            if (Regex.IsMatch(valStr, @"^[\p{L}]+$"))                       
                return true;
            else
                return false;
        }

        public static bool validateValueRng(decimal valDec)                 // provjera nalazi li se broj u intervalu [1,5]
        {
            if (valDec < 1 || valDec > 5)
            {
                return false;
            }
            else
                return true;
        }

    }

    public class StudentContainer : List<Student>                           // Containter koji u memoriji sadrzi listu ucenika
    {
        public static List<Student> Students = new List<Student>();
    }
}
