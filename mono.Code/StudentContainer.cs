using System.Collections.Generic;

namespace mono.Code
{
    public class StudentContainer : List<Student>                           // Containter koji u memoriji sadrzi listu ucenika
    {
        public static List<Student> Students = new List<Student>();
    }
}
