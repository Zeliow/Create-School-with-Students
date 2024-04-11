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
		case "1": addInListnewStudent(); break;
        case "2": removeFromListStudent(); break;
		default:
			break;
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
    //id студента 
    //id 
}