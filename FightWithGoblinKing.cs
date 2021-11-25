using System;

namespace StoryLine
{
    public class FightWithGoblinKing : Fight
    {
        public void FightGoblinKing(Enemy goblinKing, Player player)
        {
            FightEnemy(goblinKing, player);
            GoblinKingSkillActived(goblinKing, player);
        }

        public void GoblinKingSkillActived(Enemy goblinKing, Player player)
        {
            RepeatStory repeat = new RepeatStory();            
            System.Console.WriteLine("Goblin King : Ack... Please!! Don't kill me!! I'll give all my valuables");
            Console.ReadKey();
            System.Console.WriteLine("                              Goblin king took out all the valuables");
            System.Console.WriteLine("                                     Do you want to take it?");
            System.Console.WriteLine();
            System.Console.WriteLine("                                       1) Yes      2) No");
            var stringNull = Console.ReadLine();
            while(stringNull == "" || stringNull != "2" && stringNull != "1")
            {
                stringNull = repeat.GoblinKingSkillActived();
            }
            var yourChoice = Convert.ToInt32(stringNull);
            if(yourChoice == 1)
            {
                System.Console.WriteLine();              
                System.Console.WriteLine("                                You take all the valuables");
                Thread.Sleep(1000);
                Console.Clear();
                System.Console.WriteLine("                                          Suddenly");
                Thread.Sleep(1000);
                System.Console.WriteLine("                            The goblin king stabbed you in the back");
                Thread.Sleep(1000);
                System.Console.WriteLine("                                        And you died");
                Thread.Sleep(500);
                System.Console.WriteLine("Goblin King : Hahaha.... Very Stupid!!");
                Console.ReadKey();
                PlayerDied(player);
            }
            if(yourChoice == 2)
            {
                System.Console.WriteLine();                                       
                System.Console.WriteLine("                        You rejected valuables and then killed the goblin king");                
                Thread.Sleep(500);
                System.Console.WriteLine("Goblin King : Noooo.....");
                Console.ReadKey();
                Console.Clear();         
                Console.WriteLine();
                System.Console.WriteLine("                                 You Have Defeated All Goblin");           
                System.Console.WriteLine("                                     Your Mision Complete");
                Console.ReadKey();
                
            }
        }        
    }
}