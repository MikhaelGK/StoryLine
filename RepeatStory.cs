using System;

namespace StoryLine
{
    public class RepeatStory
    {
        public string? StoryAfterPlayerName(Player player)
        {
            var name = player.Name;
            Console.Clear();
            System.Console.WriteLine();            
            System.Console.WriteLine($"Old Man : {name}?? It's a beautiful name");            
            System.Console.WriteLine($"Old Man : Have you ever heard about Mount Sirius?");            
            System.Console.WriteLine();
            System.Console.WriteLine("1. I have heard about it");
            System.Console.WriteLine("2. No, I never heard of it");
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            return stringNull;
        }

        public string? PrepareToGoToTheMountain(Player player)
        {            
            Console.Clear();
            System.Console.WriteLine("Your Home");            
            System.Console.WriteLine("                  When you're at home, you prepare your equipment to go to Mount Sirius");
            System.Console.WriteLine("                            Once you are ready, you see the knife and the bow");
            System.Console.WriteLine();            
            System.Console.WriteLine("1. Pick up the knife");
            System.Console.WriteLine("2. Pick up the bow");            
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            return stringNull;
        }

        public string? AfterDefeatHuggyWuggy(Player player)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("                                  Huggy Wuggy has died...");
            System.Console.WriteLine("             Suddenly, Your body emits light and evolves to form new skills ");                                
            System.Console.WriteLine();
            System.Console.WriteLine("Choose your skill : ");
            System.Console.WriteLine(" 1. Strength Enhance : Enhance your strength by 25 every your skill active");
            System.Console.WriteLine(" 2. Lifesteal : Heal 50% health every attacked the enemy");
            System.Console.WriteLine(" 3. Perfect Defense : Immune to every enemy attack");
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            return stringNull;
        }
    }
}