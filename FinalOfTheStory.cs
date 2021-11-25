using System;

namespace StoryLine
{
    public class FinalOfTheStory
    {
        public void AfterChooseTheWeapon(Player player)
        {
            RepeatStory repeat = new RepeatStory();
            
            Console.Clear();
            System.Console.WriteLine("                          After that, you follow the path to Mount Sirius");
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
        }
        public void MeetWithRoyaleMinion(Player player, int yourChoice)
        {
            Enemy royaleMinion = new Enemy("Royale Minion", 2000, "Meteor Ball", "Trisula", 30);
            Console.Clear();           
            if(yourChoice == 1)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("You : Hey Old Man, Let's we break a moment");
                Console.ReadKey();                
                System.Console.WriteLine("                                 Zzzz... Ngok...");
                Thread.Sleep(1000);
                System.Console.WriteLine("                                 You Fall Asleep");  
                Thread.Sleep(1000);
                System.Console.WriteLine("              After you wake up, you see the old man has disappeared");
                Thread.Sleep(1000);
                System.Console.WriteLine("You : Woahm... I fell asleep until midnight. I have to continue this journey");
                Console.ReadKey();
                System.Console.WriteLine("You : Wait, where is old man?? Is he disappear?");
                Console.ReadKey();
                System.Console.WriteLine("You : Oh my god, I must find he right row");                
                Console.ReadKey();
                System.Console.WriteLine("                    You looking for the old man in the forest");  
                Thread.Sleep(1000);
                System.Console.WriteLine("                  Then, You see the light of fire in the forest");
                Thread.Sleep(1000);
                System.Console.WriteLine("                       You ran towards the source of light");
                Thread.Sleep(1000);
                System.Console.WriteLine("                         But, you hear someone needs help");
                Thread.Sleep(1000);
                System.Console.WriteLine("Unknown : Help!!! (male voice)");
                Console.ReadKey();
                System.Console.WriteLine("You     : Huh, there's someone needs help. I have to help him");                
                Console.ReadKey();
                System.Console.WriteLine("                         When you are at the sound source");
                Console.ReadKey();                
                System.Console.WriteLine("You           : Stop! Don't hurt him!!");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : Who are you?");
                Console.ReadKey();
                System.Console.WriteLine("You           : I'm is Migto and I'll save this man");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : Why you so confident? I'm Royale Minion and I'll kill you and this Old Man");
                Console.ReadKey();
                System.Console.WriteLine("You           : Old Man???");
                Console.ReadKey();
                System.Console.WriteLine("Old Man       : Hey Young Man, please help me!!");
                Console.ReadKey();                                
                System.Console.WriteLine("You           : Stay calm and I'll save you");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : Hahahahahaa....");
                Console.ReadKey();
            }
            if(yourChoice == 2)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("You : Ack...My head feels so dizzy. I must continue this journey");                
                Console.ReadKey();
                System.Console.WriteLine("                       On the road, You fainted");
                Thread.Sleep(1000);
                System.Console.WriteLine("                     You woke up from your fainting"); 
                Thread.Sleep(1000);
                System.Console.WriteLine("                      Suddenly you're in a dungeon."); 
                Thread.Sleep(1000);
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