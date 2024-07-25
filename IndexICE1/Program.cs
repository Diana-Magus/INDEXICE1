// See https://aka.ms/new-console-template for more information
using IndexICE1;

namespace IndexICE1
{
    internal class Progam
    {
        static void Main(string[] args)
        {
            
            Player player1 = new Player(10, 104, "DianaMagus22","Warlock", "Half Elf", "Astrid");

            Console.WriteLine(player1[0]);
            Console.WriteLine(player1[1]);
            Console.WriteLine(player1[2]);
            Console.WriteLine(player1[3]);
            Console.WriteLine(player1[4]);

            Console.WriteLine("");


            Console.WriteLine("Player Tag: " + player1["playertag"]);

            Console.WriteLine("Character level: " + player1["level"]);

            Console.WriteLine("Character health: " + player1["health"]);

            Console.WriteLine("Character class: " + player1["characterclass"]);

            Console.WriteLine("Character race: " + player1["characterrace"]);

            Console.WriteLine("Character name: " + player1["charactername"]);
        }
    }
}



