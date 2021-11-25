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
                System.Console.WriteLine("You           : Ack...My head feels so dizzy. I must continue this journey");                
                Console.ReadKey();
                System.Console.WriteLine("                       On the road, You passed out");
                Thread.Sleep(1000);
                System.Console.WriteLine("                   When You wake up from your fainting"); 
                Thread.Sleep(1000);
                System.Console.WriteLine("                 You are on the field with your hands tied");
                Thread.Sleep(1000);
                System.Console.WriteLine();
                System.Console.WriteLine("You           : Hah!? Where am I? Anyone help me!");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : Finally, you wake up");                        
                Console.ReadKey();
                System.Console.WriteLine("You           : Who the hell are you?? What place is this?? and where is the old man who was with me??");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : Ugh you so noisy, too much question");
                Console.ReadKey();
                System.Console.WriteLine("You           : Let me go, you ugly monster!!");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : How dare you call me ugly. I'm Royale Minion");
                Console.ReadKey();
                System.Console.WriteLine("You           : What do you want??");
                Console.ReadKey();  
                System.Console.WriteLine("Royale Minion : I should be the one asking you, what brought you here?");
                Console.ReadKey();
                System.Console.WriteLine("You           : it's none of your bussines");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : Answer me or I will burn this old man");
                Console.ReadKey();
                System.Console.WriteLine("You           : Please, don't do that!!");
                Console.ReadKey();
                System.Console.WriteLine("Royale Minion : Ck, Let's make a deal, fight with me, if you win, I will give you the old man. but, if you lose, I'll eat both of you");
                Console.ReadKey();
            }
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("Your Mision : Save the old man");            
            System.Console.WriteLine($"{royaleMinion.Name} :");
            System.Console.WriteLine($"   Damage dealt : {royaleMinion.Damage}");
            System.Console.WriteLine($"   Skill : {royaleMinion.Skill}");
            Console.ReadKey();
            FightWithRoyaleMinion fight = new FightWithRoyaleMinion();
            fight.FightRoyaleMinion(royaleMinion, player);
        }

        public void TheEnd(Player player)
        {
            Console.Clear();
            System.Console.WriteLine("                          After you kill the royale minion");
            Thread.Sleep(1000);
            System.Console.WriteLine("                        The sky turned dark and made a sound");            
            Thread.Sleep(1000);
            System.Console.WriteLine();
            System.Console.WriteLine("You           : Why the sky turn into dark??");
            Console.ReadKey();
            System.Console.WriteLine("Unknown Sound : The stanger, I suggest you to leave this forest or I will kill you");            
            Console.ReadKey();
            System.Console.WriteLine();
            System.Console.WriteLine("                        After that, you continue your journey");
            Thread.Sleep(1000);
            Console.Clear();
            System.Console.WriteLine();                                     
            System.Console.WriteLine("                                      The End");
        }
    }
}