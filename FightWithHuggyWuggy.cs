using System;

namespace StoryLine
{
    public class FightWithHuggyWuggy : Fight
    {
        public void FightHuggyWuggy(Enemy huggywuggy, Player player)
        {         
            FightEnemy(huggywuggy, player);

            if(huggywuggy.Health <= 0)
            {
                BeginningOfTheStory story = new BeginningOfTheStory();
                Console.Clear();
                System.Console.WriteLine();
                System.Console.WriteLine($"                                 You Have Defeated {huggywuggy.Name}");           
                System.Console.WriteLine( "                                    Your Mision Complete");
                Thread.Sleep(2000);
                story.AfterDefeatHuggyWuggy(player);            
            }
        }        
    }
}