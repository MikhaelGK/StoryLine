using System;

namespace StoryLine
{
    public class MiddleOfTheStory
    {
        public void ContinueChapter(Player player)
        {            
            Console.Clear();
            System.Console.WriteLine("On Mount Sirius"); 
            Thread.Sleep(1000);
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
            Thread.Sleep(2000);
            OnArendelleForest(player);            
        }

        public void OnArendelleForest(Player player)
        {
            RepeatStory repeat = new RepeatStory();

            Console.Clear();
            System.Console.WriteLine("Arendelle Forest");
            Thread.Sleep(1000);
            System.Console.WriteLine();
            System.Console.WriteLine("                  You Meet With Old Man Again");
            System.Console.WriteLine();
            Thread.Sleep(1000);
            System.Console.WriteLine("1. Talk To Him");
            System.Console.WriteLine("2. Ignore Him");
            var stringNull = Console.ReadLine();            
            while(stringNull == "" || stringNull != "2" && stringNull != "1")
            {
                stringNull = repeat.OnArendelleForest(player);
            }
            var yourChoice = Convert.ToInt32(stringNull);
            if(yourChoice == 1)
            {
                Console.Clear();
                System.Console.WriteLine();
                System.Console.WriteLine("You     : Yoo... Old man, What are you doing in here?");
            }
            if(yourChoice == 2)
            {
                Console.Clear();
                System.Console.WriteLine();
                System.Console.WriteLine("Old Man : Yoo.... Young man, Have you ever thought you should say something when old man are around?");
                Console.ReadKey();
                System.Console.WriteLine("You     : Sorry, I didn't see you");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : I thought you did it on purpose");
                Console.ReadKey();
                System.Console.WriteLine("You     : (Laugh)Hahahahaaa.....");
                Console.ReadKey();
                System.Console.WriteLine("You     : Alright old man, What are you doing in here?");
            }
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
            Console.ReadKey();
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }   
            }                
            GoblinComesToYou(player);
        }

        public void GoblinComesToYou(Player player)
        {            
            System.Console.WriteLine();
            System.Console.WriteLine("                            Suddenly");
            Thread.Sleep(2000);
            System.Console.WriteLine("                  The goblin king came to you");
            System.Console.WriteLine("                     with his subordinates");
            System.Console.WriteLine();
            Console.ReadKey();
        }    
    }
}