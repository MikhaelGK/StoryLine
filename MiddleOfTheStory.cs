using System;

namespace StoryLine
{
    public class MiddleOfTheStory
    {
        public void ContinueChapter(Player player)
        {            
            Console.Clear();
            System.Console.WriteLine("On Mount Sirius"); 
            Thread.Sleep(2000);
            System.Console.WriteLine();            
            System.Console.WriteLine("                  The Guardian Dragon Has Ordered");
            System.Console.WriteLine("                    The Goblin King To Kill You");
            Thread.Sleep(2000);
            System.Console.WriteLine();
            System.Console.WriteLine("The Dragon  : I commanded you to kill this young man");
            Console.ReadKey();
            System.Console.WriteLine("Goblin King : Yes, Your Majesty");
            Console.ReadKey();
            Console.Clear();            
            System.Console.WriteLine();
            System.Console.WriteLine("                  After The Dragon Ordered The Goblin King");
            System.Console.WriteLine("                          The Dragon Disappear");
            Thread.Sleep(5000);
            OnArendelleForest(player);            
        }

        public void OnArendelleForest(Player player)
        {
            Console.Clear();
            System.Console.WriteLine("Arendelle Forest");
            Thread.Sleep(2000);
            System.Console.WriteLine();
            System.Console.WriteLine("                  You Meet With Old Man Again");
            System.Console.WriteLine();
            System.Console.WriteLine("1. Talk To Him");
            System.Console.WriteLine("2. Ignore Him");
            var stringNull = Console.ReadLine();            
            while(stringNull == "" || stringNull != "2" && stringNull != "1")
            {
                stringNull = repeat.OnArendelleForest(player);
            }
            var yourChoice = Convert.ToInt32(Console.ReadLine());
            if(yourChoice == 1)
            {
                Console.Clear();
                System.Console.WriteLine();
                System.Console.WriteLine("You     : Yoo... old man, What are you doing in here?");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : Nothing, Just walking around");
                Console.ReadKey();
                System.Console.WriteLine("You     : Well, I thought you in the village");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : You know, sometimes people can get bored in the village");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : I see you look very good. Did your journey go well?");
                Console.ReadKey();
                System.Console.WriteLine("You     : Maybe, not bad for today");
            }
            if(yourChoice == 2)
            {
                Console.Clear();
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
        }

        public void GoblinComesToYou(Player player)
        {
            Console.Clear();
            System.Console.WriteLine("Arendelle Forest");
            Thread.Sleep(2000);
            System.Console.WriteLine();
            System.Console.WriteLine("                  The goblin king came to you");
            System.Console.WriteLine("                     with his subordinates");
            System.Console.WriteLine();
            Console.ReadKey();
        }    
    }
}