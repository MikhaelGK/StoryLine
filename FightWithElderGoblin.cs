using System;

namespace StoryLine
{
    public class FightWithElderGoblin
    {
        public void FightElderGoblin(Enemy elderGoblin, Enemy goblinKing,Player player)
        {         
            Fight fight = new Fight();
            while(elderGoblin.Health > 0 && player.Health > 0)
            {                                             
                var enemySkillActive = fight.EnemySkillChance();            
                var stringNull = fight.Information(elderGoblin, player, enemySkillActive);
                if(stringNull == "" || stringNull != "2" && stringNull != "1")
                {
                    continue;                   
                }
                var enemyChoice = fight.EnemyAttackChance();
                var yourChoice = Convert.ToInt32(stringNull);
                if (yourChoice == 1 && enemyChoice == 1)
                {
                    System.Console.WriteLine($"     You Choose Attack {elderGoblin.Name}");
                    System.Console.WriteLine($"    {elderGoblin.Name} Choose Attack {player.Name}");
                    elderGoblin.Health -= player.Damage;
                    player.Health -= elderGoblin.Damage;
                    System.Console.WriteLine("         Your Attack Successful");
                    Thread.Sleep(2000);
                    if(enemySkillActive > 7)
                    {
                        elderGoblin.Damage += 1;
                    }
                    continue;
                }
                if (yourChoice == 2 && enemyChoice == 1)
                {
                    System.Console.WriteLine($"           You Choose Defense");
                    System.Console.WriteLine($"    {elderGoblin.Name} Choose Attack {player.Name}");
                    Thread.Sleep(2000);
                    Random random = new Random();
                    var defendChange = random.Next(10)+1;
                    if(defendChange > 5)
                    {
                        System.Console.WriteLine("         Your Defense Failed");
                        player.Health -= elderGoblin.Damage;                    
                        if(enemySkillActive > 7)
                        {
                            elderGoblin.Damage += 1;
                        }                    
                        Thread.Sleep(2000);
                        continue;
                    }
                    if(defendChange <= 5)
                    {
                        System.Console.WriteLine("         Your Defense Successful");
                        Thread.Sleep(2000);
                        continue;
                    }
                }
                if(yourChoice == 1 && enemyChoice == 2)
                {
                    System.Console.WriteLine($"     You choose attack {elderGoblin.Name}");
                    System.Console.WriteLine($"     {elderGoblin.Name} choose defend");
                    Thread.Sleep(2000);
                    Random random = new Random();
                    var defendChange = random.Next(10)+1;
                    if(defendChange > 5)
                    {
                        System.Console.WriteLine($"    {elderGoblin.Name} Defense Failed");
                        elderGoblin.Health -= player.Damage;
                        Thread.Sleep(2000);
                        continue;
                    }
                    if(defendChange <= 5)
                    {
                        System.Console.WriteLine($"      {elderGoblin.Name} Defense Successful");
                        Thread.Sleep(2000);
                        continue;
                    }
                }
                if(yourChoice == 2 && enemyChoice == 2)
                {
                    System.Console.WriteLine($"     You choose defend");
                    System.Console.WriteLine($"    {elderGoblin.Name} choose defend");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            if(player.Health <= 0)
            {
                var stringNull = fight.PlayerDied();
                
            }

            if(elderGoblin.Health <= 0)
            {               
                FightWithGoblinKing fightGoblinKing = new FightWithGoblinKing(); 
                Console.Clear();
                Console.WriteLine($"                                 You Have Defeated {elderGoblin.Name}");           
                Console.ReadKey();                
                fightGoblinKing.FightGoblinKing(goblinKing, player);            
            }
        }        
    }
}