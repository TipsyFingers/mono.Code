using System.Collections.Generic;
using System.Linq;

namespace mono.Code
{
    public class StudentContainer : List<Student>                           // Containter koji u memoriji sadrzi listu ucenika
    {
        public static List<Student> Students = new List<Student>();

        public static Student updateStudent(int _id, string _fname, string _lname, decimal _gpa)
        {
            var _student = Students.Where(s => s.Id == _id).FirstOrDefault();

            _student.Id = _id;
            _student.FName = _fname;
            _student.LName = _lname;
            _student.GPA = _gpa;

            return _student;
        }
    }
}
