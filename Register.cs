using System;
using System.Runtime.CompilerServices;

namespace PersonalRegister
{
    internal class Register()
    {
        // Uses the input from UsingPersonalsProps to add a new person to the register
        private static string addPerson(string fname, string lname, int pment)
        {
            Personnels personals = new()
            {
                FirstName = fname,
                LastName = lname,
                Payment = pment
            };
            Personnels.RegisterList.Add(personals);
            return $"You have added {fname} {lname} to the register!";
        }

        //Takes inputs for the new person
        public static string createNewPerson()
        {
            Console.WriteLine("Type a firstname: ");
            string? fname = Console.ReadLine();

            Console.WriteLine("Type a lastname: ");
            string? lname = Console.ReadLine();

            Console.WriteLine("How much do they earn each month?: ");

            int pment = int.Parse(Console.ReadLine());
            
            return addPerson(fname, lname, pment);
        }

        //Shows all personnels in the register
        public static string showPersonnels()
        {
            foreach (var item in Personnels.RegisterList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Payment + "kr i lön");
            }
            return "Those are currently on the list!";
        }

    }
}