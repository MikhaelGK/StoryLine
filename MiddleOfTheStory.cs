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
                    Thread.Sleep(500);
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
            Console.ReadKey();
            Enemy goblin = new Enemy("Goblin", 100, "", "", 2);
            Enemy elderGoblin = new Enemy("Elder Goblin", 150, "", "Axe", 4);
            Enemy goblinKing = new Enemy("Goblin King", 500, "Manipulation", "Mace", 7);  
        }           

        public void AfterGoblinKingDead(Player player)
        {
            RepeatStory repeat = new RepeatStory();

            Console.Clear();
            System.Console.WriteLine("                                          You Defeat The Goblin King");
            Thread.Sleep(1000);
            System.Console.WriteLine("                                      Choose the weapon you want to claim");
            System.Console.WriteLine();
            Thread.Sleep(1000);
            System.Console.WriteLine("1. Sword");
            System.Console.WriteLine("2. Axe");
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
                player.Weapon = "Axe";
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

            AfterChooseTheWeapon(player);
        }

        public void AfterChooseTheWeapon(Player player)
        {
            RepeatStory repeat = new RepeatStory();
            
            Console.Clear();
            System.Console.WriteLine("                                      After that, you follow the path to Mount Sirius.");
            System.Console.WriteLine();
            Thread.Sleep(1000);
            System.Console.WriteLine("You : I feel so tired");
            Console.ReadKey();
            System.Console.WriteLine("You : Should I take a break or continue this journey?");
            Console.ReadKey();
            System.Console.WriteLine();
            System.Console.WriteLine("1. Take a break");
            System.Console.WriteLine("2. Continue this journey");
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            while (stringNull == "" || stringNull != "2" && stringNull != "1")
            {
                stringNull = repeat.AfterChooseTheWeapon(player);
            }
            Console.Clear();
            var yourChoice = Convert.ToInt32(stringNull);
            MeetWithRoyaleMinion(player, yourChoice);
        }

        public void MeetWithRoyaleMinion(Player player, int yourChoice)
        {
           Console.Clear();           
            if(yourChoice == 1)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("You : Maybe I need to break");
                Console.ReadKey();                
                System.Console.WriteLine("                          Zzzz... Ngok...");
                Thread.Sleep(1000);
                System.Console.WriteLine("                          You Fall Asleep");  
                Console.ReadKey(); 
                System.Console.WriteLine("After you wake up, you energy is filled.");
                Console.ReadKey();
                System.Console.WriteLine("And then you continue your journey to Mount Sirius.");  
                Console.ReadKey();
                System.Console.WriteLine("You : Woahm... I fell asleep until midnight. I have to continue this journey.");
                Console.ReadKey();
                System.Console.WriteLine("You : This road is very dark."); 
                Console.ReadKey();
                System.Console.WriteLine("                       You see the light of fire in the middle of the journey.");
                Console.ReadKey();              
                System.Console.WriteLine("Old Man : Help!!!");
                Console.ReadKey();
                System.Console.WriteLine("You : Huh, there's someone who's in danger I have to help him.");
                Console.ReadKey();
                System.Console.WriteLine("                       You ran towards the source of light and sound earlier.");
                Console.ReadKey();
                System.Console.WriteLine("You : Stop! If you want to hurt him, fight me first.");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : ARRRGGHHH.... Who are you? How dare you challenge me. You don't know who I am?");
                Console.ReadKey();
                System.Console.WriteLine("You : You don't need to know who I am and I don't want to know who you are.");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : Let's fight! Let's prove who is a coward!");
                Console.ReadKey();
            }
            if(yourChoice == 2)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("You : Ack...My head feels so dizzy. I must continue this journey");                
                Console.ReadKey();
                System.Console.WriteLine("                       On the road, You fainted");
                Console.ReadKey();
                System.Console.WriteLine("                       You woke up from your fainting. Suddenly you're in a dungeon."); 
                Console.ReadKey();
                System.Console.WriteLine("You : Hah!? Where am I? Anyone help me!");
                Console.ReadKey();
                System.Console.WriteLine("                       You hear the sound of footsteps.");      
                Console.ReadKey();
                System.Console.WriteLine("You : Who's there? ");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : I am the ruler of this territory. Why did you come here, stranger.");
                Console.ReadKey();
                System.Console.WriteLine("You : It's none of your business I came here. Let me go now!");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : Give me the ransom first. I'll let you go.");
                Console.ReadKey();
                System.Console.WriteLine("You : Cunning! If you want, fight with me.");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : How brave you are! HAHAHAHA I accept your challenge. If you win I will free you, if you lose your treasure or your life will disappear.");
                Console.ReadKey();
                System.Console.WriteLine("You : All right, I accept this agreement.");
                Console.ReadKey();         
            }
        }
    }
}