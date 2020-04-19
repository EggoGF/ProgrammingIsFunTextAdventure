using System;

namespace ProgrammingIsFunTextAdventure
{
    class Program
    {
        static void Main()
        {
            string CharacterName = "John Doe";

            Console.WriteLine("Welcome to Quarantine Explorer!");
            Console.WriteLine("What is your name, adventurer?");

            CharacterName = Console.ReadLine();
            Console.WriteLine("Excellent!  You are known as " + CharacterName + " the Great.  The bards will sing your tales for decades to come.");
        }
    }
}
