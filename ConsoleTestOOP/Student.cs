using CreateCshool;

namespace LibStudent
{
    internal class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Guid Id;

        public Student (string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
