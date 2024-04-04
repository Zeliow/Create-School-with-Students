using LibStudent;

namespace CreateCshool
{
    internal class School
    {
        public string Name;
        public List<Student> Students;

        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
        }
    }
    
}

