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
            Thread.Sleep(1000);
            System.Console.WriteLine("                  The goblin king came to you");
            System.Console.WriteLine("                     with his subordinates");
            System.Console.WriteLine();
            Thread.Sleep(1000);
            System.Console.WriteLine("Goblin King : Hey young man, be honorable to die by my hand!!!");
            Console.ReadKey();
            System.Console.WriteLine("You         : Hah?? What do you mean?? Who are you??");
            Console.ReadKey();
            System.Console.WriteLine("Goblin King : I'm the king of the goblin. My lord ordered me to kill you");
            Console.ReadKey();
            System.Console.WriteLine("Goblin King : Rest assured hey young man, I will send you to the hell hahahahaa...(Laugh)");
            Console.ReadKey();
            System.Console.WriteLine("Goblin King : My subordinates, kill this young man hahahahaa...(Laugh)");
        }   

        public void AfterGoblinKingDead(Player player)
        {
          Console.Clear();
          System.Console.WriteLine("                     Finally, You Can Defeat The Goblin King!!");
          Console.ReadKey();
          System.Console.WriteLine("                     As a reward for killing the Goblin King, you get weapons for self-defense.");
          Console.ReadKey();
          System.Console.WriteLine("                     Choose the weapon you want to claim");
          System.Console.WriteLine();
          Thread.Sleep(1000);
          System.Console.WriteLine("1. Sword");
          System.Console.WriteLine("2. Chopper");
          System.Console.WriteLine("3. Polearm");
          var stringNull = Console.ReadLine();
          while (stringNull == "" || stringNull != "2" && stringNull != "1" && stringNull != "3")
          {
             stringNull = repeat.AfterGoblinKingDead(player); 
          }
          var yourChoice = Convert.ToInt32(stringNull);
          if(yourChoice == 1)
          {
              player.Weapon = "Sword";
              System.Console.WriteLine($"               Your Choice is {player.Weapon}");
              player.Damage = 25;
              Thread.Sleep(2000);

          }
          if(yourChoice == 2)
          {
              player.Weapon = "Chopper";
              System.Console.WriteLine($"               Your Choice is {player.Weapon}");
              player.Damage = 25;
              Thread.Sleep(2000);
          }
          if(yourChoice == 3)
          {
              player.Weapon = "Polearm";
              System.Console.WriteLine($"               Your Choice is {player.Weapon}");
              player.Damage = 25;
              Thread.Sleep(2000);
          }
        }

        public void AfterChooseTheWeapon(Player player)
        {
            System.Console.WriteLine("After that, you follow the path to Mount Sirius.");
            System.Console.WriteLine();
            Thread.Sleep(1000);

            System.Console.WriteLine("You    : I feel so tired.");
            Console.ReadKey();
            System.Console.WriteLine("You     : Should I take a break or continue this journey?");
            Console.ReadKey();
            System.Console.WriteLine("1. Maybe i need to break");
            System.Console.WriteLine("2. I have to continue this journey");
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            while (stringNull == "" || stringNull != "2" && stringNull != "1")
            {
                stringNull == repeat.AfterChooseTheWeapon(player);
            }
            Console.Clear();
            var yourChoice = Convert.ToInt32(stringNull);
            if(yourChoice == 1)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("You      : Maybe I can sleep here for a while.");
                Console.ReadKey();
                System.Console.WriteLine("  *Zzzz... Ngok...*");
                Console.ReadKey();
            }
            if(yourChoice == 2)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("You       : I can continue this journey");
                Console.ReadKey();
                System.Console.WriteLine("You       : ack...My head feels so dizzy.");
                Console.ReadKey();
                System.Console.WriteLine(" *You passed out* ");
            }
        }
    }
}