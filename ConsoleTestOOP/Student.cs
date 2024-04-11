using CreateCshool;

namespace LibStudent
{
    
    internal class Student
    {
        public string FirstName;
        public string LastName;
        public uint Age;

        public Student (string firstName, string lastName, uint age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
