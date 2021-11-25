using System;

namespace StoryLine
{
    public class FightWithElderGoblin : Fight
    {
        public void FightElderGoblin(Enemy elderGoblin, Enemy goblinKing,Player player)
        {         
            FightEnemy(elderGoblin, player);            

            if(elderGoblin.Health <= 0)
            {               
                FightWithGoblinKing fightGoblinKing = new FightWithGoblinKing(); 
                Console.Clear();
                Console.WriteLine($"                                 You Have Defeated {elderGoblin.Name}");           
                Thread.Sleep(1000);   
                fightGoblinKing.FightGoblinKing(goblinKing, player);            
            }
        }        
    }
}