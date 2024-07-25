// See https://aka.ms/new-console-template for more information
using IndexICE1;

namespace IndexICE1
{
    internal class Progam
    {
        static void Main(string[] args)
        {

            Player player1 = new Player(10, 104, "DianaMagus22", "Warlock", "Half Elf", "Astrid");
            Player player2 = new Player(20, 50, "PaleSky1", "Archer", "Dwarf", "King Pale");

            Console.WriteLine(player1[0]);
            Console.WriteLine(player1[1]);
            Console.WriteLine(player1[2]);
            Console.WriteLine(player1[3]);
            Console.WriteLine(player1[4]);
            Console.WriteLine(player1[5]);
            Console.WriteLine();
            Console.WriteLine("health: " + player1["Health"]);
            Console.WriteLine("level: " + player1["Level"]);
            Console.WriteLine("playertag: " + player1["PlayerTag"]);
            Console.WriteLine("charaterclass: " + player1["CharacterClass"]);
            Console.WriteLine("charactername: " + player1["CharacterName"]);
            Console.WriteLine();
            Console.WriteLine(player2[0]);
            Console.WriteLine(player2[1]);
            Console.WriteLine(player2[2]);
            Console.WriteLine(player2[3]);
            Console.WriteLine(player2[4]);
            Console.WriteLine(player2[5]);
            Console.WriteLine();
            Console.WriteLine("health: " + player2["Health"]);
            Console.WriteLine("level: " + player2["Level"]);
            Console.WriteLine("playertag: " + player2["PlayerTag"]);
            Console.WriteLine("charaterclass: " + player2["CharacterClass"]);
            Console.WriteLine("charactername: " + player2["CharacterName"]);
        }
    }
}



