namespace mono.Code
{
    public class StudentIdGenerator                                         // najjednostavniji oblik generiranja ID-a
    {
        public static int GetID()
        {
            int id = StudentContainer.Students.Count;
            return id;
        }
    }
}
