using CreateCshool;
using LibStudent;

Console.Write("Введите имя новой школы: ");
string schoolName = Console.ReadLine();
School newSchool = new School(schoolName);
while (true)
{
    Console.WriteLine("Выберите необходимое действие: ");
    Console.WriteLine("1. Список учеников\n2. Добавить ученика\n3. Удалить ученика");
    string anwser = Console.ReadLine();
	switch (anwser)
	{
        case "1": GetListStudents(); break;
		case "2": addInListnewStudent(); break;
        case "3": removeFromListStudent(); break;
		default:
			break;
	}
}

void GetListStudents()
{
    if (newSchool.Students.Count == 0) Console.WriteLine($"Текущий список учеников школы {newSchool.Name} пуст!");
    else
    {
        int userID = 1;
        Console.WriteLine($"{"ID", -10}{"Name", -10}{"LastName", -10}{"Age", -10}");
        foreach (var item in newSchool.Students)
        {              
            Console.WriteLine($"{userID, -10}{item.FirstName, -10}{item.LastName, -10}{item.Age, -10}");
            userID++;
        }
    }

}

void addInListnewStudent()
{
    Console.Write("Введите имя ученика: ");
    string firstName = Console.ReadLine();
    Console.Write("Введите фамилию ученика: ");
    string lastName = Console.ReadLine();
    Console.Write("Введите возраст ученика: ");
    int age = int.Parse(Console.ReadLine());
    Student newStudent = new Student(firstName, lastName, age);
    newSchool.Students.Add(newStudent);
    Console.WriteLine($"Ученик {firstName} {lastName} добавлен в школу {newSchool.Name}");
}


void removeFromListStudent()
{
    Console.Write("Введите ID ученика для удаления: ");
    int numberStudent = int.Parse(Console.ReadLine());
    Console.WriteLine(
        $"Ученик {newSchool.Students[numberStudent - 1].FirstName} " +
        $"{newSchool.Students[numberStudent - 1].LastName} " +
        $"Был успешно удалён!");
    newSchool.Students.RemoveAt(numberStudent - 1);
}