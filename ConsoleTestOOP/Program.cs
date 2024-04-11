using CreateCshool;
using LibStudent;

Console.Write("Введите имя новой школы: ");
string schoolName = Console.ReadLine();
School newSchool = new School(schoolName);
while (true)
{
    Console.Write("Выберите необходимое действие: ");
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
    if (newSchool.Students.Count == 0) Console.WriteLine("Текущий список учеников пуст!");
    else
    {
        int id = 1;
        foreach (var item in newSchool.Students)
        {
            
            //add id
            Console.WriteLine($"{"ID",-10}{"Name",-10}{"LastName",-10}{"Age",-10}");
            Console.WriteLine($"{id,-10}{item.FirstName,-10}{item.LastName,-10}{item.Age,-10}");
            id++;
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
    uint age = uint.Parse(Console.ReadLine());
    Student newStudent = new Student(firstName, lastName, age);
    newSchool.Students.Add(newStudent);
}

void removeFromListStudent()
{
    int numberStudent = int.Parse(Console.ReadLine());
    newSchool.Students.RemoveAt(numberStudent);
}