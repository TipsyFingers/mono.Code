namespace mono.Code
{
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
}
