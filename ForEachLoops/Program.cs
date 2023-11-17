
//Console application?
//Ask user for first name?
//Keep asking for first names until no more?
//for each name say hello on the console?

List<string> names = new List<string>();
string firstName = string.Empty;
bool input = false;

do
{
    Console.WriteLine();
    Console.Write("What is your first name: ");
	firstName = Console.ReadLine();
	if (firstName != string.Empty || firstName != null)
	{
		names.Add(firstName);
	}
    Console.WriteLine();
    Console.Write("Is there another first name y/n: ");

	if (Console.ReadLine() == "y")
	{
		input = true;
    }
	else
	{
		foreach (string name in names)
		{
			Console.WriteLine();
            Console.WriteLine($"Hello {name}");
        }

		break;
	}
} while (input == true);






