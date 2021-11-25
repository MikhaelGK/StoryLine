using System;

namespace StoryLine
{
    public class FightWithRoyaleMinion : Fight
    {
        public void FightRoyaleMinion(Enemy royaleMinion, Player player)
        {
            FightEnemy(royaleMinion, player);
            if(royaleMinion.Health <= 0)
            {                
                Console.Clear();
                System.Console.WriteLine();
                System.Console.WriteLine($"                                 You Have Defeated {royaleMinion.Name}");           
                System.Console.WriteLine( "                                    Your Mision Complete");
                Thread.Sleep(2000);                
            }
        }
    }
}