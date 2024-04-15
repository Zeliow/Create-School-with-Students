using CreateCshool;
using LibStudent;
using static System.Console;

School newSchool = new School();

bool flagOn = true;
while (flagOn)
{
    WriteLine("Выберите необходимое действие: ");
    WriteLine("1. Список учеников\n\n2. Прекратить работу.");
    string anwser = ReadLine();
	switch (anwser)
	{
		
        case "1": newSchool.GetListStudents(); break;
		case "2": flagOn = false; break;
	}
	Clear();
}






