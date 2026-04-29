using System;
using System.Runtime.CompilerServices;

namespace PersonalRegister
{
    internal class Register()
    {
        // Uses the input from createNewPerson to add a new person to the register
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
            int pment;
            Console.WriteLine("Type a firstname: ");
            string? fname = Console.ReadLine();

            Console.WriteLine("Type a lastname: ");
            string? lname = Console.ReadLine();

            Console.WriteLine("How much do they earn each month?: ");
            string checkNumber = Console.ReadLine();

            if(int.TryParse(checkNumber, out int result))
            {
                pment = result;     
                return addPerson(fname, lname, pment);
            }
            else
                pment = 100;
                return addPerson(fname, lname, pment);
        }

        //Shows all personnels in the register
        public static string showPersonnels()
        {
            foreach (var item in Personnels.RegisterList)
            {
                Console.WriteLine("Name: " + item.FirstName + " " + item.LastName + " " + "Current Salary: " + item.Payment + "kr");
            }
            if(Personnels.RegisterList.Count != 0)
                return "Those are currently on the list!";
            else
                return "Theres none on the list!";
        }

    }
}