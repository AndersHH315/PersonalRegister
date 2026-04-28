

using PersonalRegister;

string? input = "";
do
{
    Console.WriteLine("Whats your request?");
    Console.WriteLine("Type 1 to add a new person to the register");
    Console.WriteLine("Type 2 if you want to see the register");
    Console.WriteLine("Type 3 to exit");

    input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine(Register.createNewPerson());
            break;
        case "2":
            Console.WriteLine(Register.showPersonnels());
            break;
    }

} while (input != "3");