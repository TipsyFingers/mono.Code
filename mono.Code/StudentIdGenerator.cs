namespace mono.Code
{
    public sealed class StudentIdGenerator
    {
        private static StudentIdGenerator instance;

        private int _id = 0;

        private StudentIdGenerator() { }

        public static StudentIdGenerator getInstance()
        {
            if (instance == null)
                instance = new StudentIdGenerator();

            return instance;
        }
        //...
        public static int getId()
        {
            return getInstance()._id++;
        }
    }
}
