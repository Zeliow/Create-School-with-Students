using CreateCshool;
using static System.Console;

namespace LibStudent
{
    
    internal class Student : School
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age;
        
        public int age
        {
            get { return Age; }
            set
            {
                if (value > 5 && value < 18)
                {
                    Age = value;
                }
            }
        }
        public Student (string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }


    }
}
