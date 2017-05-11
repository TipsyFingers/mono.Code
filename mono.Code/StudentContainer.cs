using System;
using System.Collections.Generic;
using System.Linq;

namespace mono.Code
{
    public class StudentContainer : List<Student>                           // Containter koji u memoriji sadrzi listu ucenika
    {
        private static List<Student> Students = new List<Student>();

        public static void addStudent(int _id, string _fname, string _lname, decimal _gpa)
        {
            Students.Add(new Student(_id, _fname, _lname, _gpa));
            Console.WriteLine("Student successfully added");
        }

        public static Student updateStudent(int _id, string _fname, string _lname, decimal _gpa)
        {
            var _student = Students.Where(s => s.Id == _id).FirstOrDefault();

            _student.Id = _id;
            _student.FName = _fname;
            _student.LName = _lname;
            _student.GPA = _gpa;

            return _student;
        }

        public static void removeStudent(int _id)
        {
            if (Students.Any(o => o.Id == _id))
            {
                Students.RemoveAt(_id);
                Console.WriteLine("Student successfully removed");
            }
            else
                Console.WriteLine("Student not found, operation failed");
        }

        public static List<Student> sortList()
        {
            var _list = Students;

            _list.OrderBy(o => o.LName);

            return _list;
        }

        public static bool containsStudId(int _id)
        {
            if (Students.Any(o => o.Id == _id))
                return true;
            else
                return false;
        }
    }
}
