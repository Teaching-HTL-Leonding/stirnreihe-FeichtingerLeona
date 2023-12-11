using Stirnreihen.Logic;
using System.Runtime.InteropServices;

bool exit = false;
LineOfPeople lineOfPeople = new LineOfPeople();
// solange exit falsch ist läuft das programm
while (!exit)
{
    Console.WriteLine("Welcome to the Stirnreihe World Record App! What do you want to do?");
    Console.WriteLine("1) Add a person to the line");
    Console.WriteLine("2) Print the line");
    Console.WriteLine("3) Clear the line");
    Console.WriteLine("4) Exit");
    int doing = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Your choice:" + doing);
    if (doing == 1)
    {
        //Neue Person wird erstellt und Daten abgefragdt
        Person person = new Person();

        Console.Write("Firstname: ");
        person.FirstName = Console.ReadLine()!;
        Console.Write("Lastname: ");
        person.LastName = Console.ReadLine()!;
        Console.Write("Height: ");
        person.Height = int.Parse(Console.ReadLine()!);

        //person wird mithilfe der AddToFront Methode zur lineOfPeople hinzugefügt
        lineOfPeople.AddToFront(person);

    }
    else if (doing == 2)
    {
        var currendPerson = lineOfPeople.First;
        // Kontrolle dass etwas inn der liste ist
        if (currendPerson == null)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            //solange die nächste person nixht leer ist wird die person ausgegeben
            while (currendPerson != null)
            {
                Console.WriteLine(currendPerson?.Person?.ToString());
                currendPerson = currendPerson?.Next;
            }
        }
    }
    else if (doing == 3)
    {
        lineOfPeople.Clear();
    }
    else if (doing == 4)
    {
        // exit ist true
        exit = true;
    }

}
