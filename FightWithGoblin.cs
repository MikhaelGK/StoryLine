using System;

namespace StoryLine
{
    public class FightWithGoblin : Fight
    {
        public void FightGoblin(Enemy goblin, Enemy elderGoblin, Enemy goblinKing, Player player)
        {                     
            FightEnemy(goblin, player);            

            if(goblin.Health <= 0)
            {                
                FightWithElderGoblin fightElderGoblin = new FightWithElderGoblin();
                Console.Clear();
                Console.WriteLine($"                                 You Have Defeated {goblin.Name}");           
                Thread.Sleep(1000);              
                fightElderGoblin.FightElderGoblin(elderGoblin, goblinKing, player);            
            }
        }        
    }
}