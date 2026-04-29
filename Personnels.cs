using System;

namespace PersonalRegister
{
    //Class with properties for Persons in the register
    public class Personnels()
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Payment { get; set; }

        public static List<Personnels> RegisterList = [];

    }
}