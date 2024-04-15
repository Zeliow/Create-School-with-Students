using LibStudent;
using static System.Console;

namespace CreateCshool
{
    internal class School
    {
        protected string Name { get; }
        protected List<Student> Students;

        public School()
        {
            Write("Введите имя школы: ");
            Name = ReadLine();
            Students = new List<Student>();
            WriteLine($"Имя школы задано! Текущее имя: {Name}");
            
        }
        public void GetListStudents()
        {
            if (Students.Count == 0) WriteLine($"Текущий список учеников школы {Name} пуст!");
            else
            {
                WriteLine("Список учеников: ");
                int userID = 1;
                WriteLine($"{"ID",-10}{"Name",-10}{"LastName",-10}{"Age",-10}");
                foreach (var item in Students)
                {
                    WriteLine($"{userID,-10}{item.FirstName,-10}{item.LastName,-10}{item.Age,-10}");
                    userID++;
                }
            }
            string anwser = ReadLine();
            WriteLine("1. Добавить ученика\n2. Удалить ученика");
            switch (anwser)
            {
                case "1": addInListnewStudent(); break;
                case "2": removeFromListStudent(); break;
                default: break;
            }

            ReadKey();
        }
        public void addInListnewStudent()
        {
            Write("Введите имя ученика: ");
            string firstName = ReadLine();
            Write("Введите фамилию ученика: ");
            string lastName = ReadLine();
            Write("Введите возраст ученика: ");
            int age = int.Parse(ReadLine());
            Student newStudent = new Student(firstName, lastName, age);
            Students.Add(newStudent);
            WriteLine($"Ученик {firstName} {lastName} добавлен в школу {Name}");
            ReadKey();
        }

        public void removeFromListStudent()
        {
            GetListStudents();
            Write("Введите ID ученика для удаления: ");
            int numberStudent = int.Parse(ReadLine());
            WriteLine(
                $"Ученик {Students[numberStudent - 1].FirstName} " +
                $"{Students[numberStudent - 1].LastName} " +
                $"Был успешно удалён!");
            Students.RemoveAt(numberStudent - 1);
            ReadKey();
        }

    }

}

