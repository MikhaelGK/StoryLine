using System;

namespace StoryLine
{
    public class FightWithGoblinKing
    {
        public void FightGoblinKing(Enemy goblinKing, Player player)
        {         
            Fight fight = new Fight();
            while(goblinKing.Health > 10 && player.Health > 0)
            {                                             
                var enemySkillActive = fight.EnemySkillChance();            
                var stringNull = fight.Information(goblinKing, player, enemySkillActive);
                if(stringNull == "" || stringNull != "2" && stringNull != "1")
                {
                    continue;                   
                }
                var enemyChoice = fight.EnemyAttackChance();
                var yourChoice = Convert.ToInt32(stringNull);
                if (yourChoice == 1 && enemyChoice == 1)
                {
                    System.Console.WriteLine($"     You Choose Attack {goblinKing.Name}");
                    System.Console.WriteLine($"    {goblinKing.Name} Choose Attack {player.Name}");
                    goblinKing.Health -= player.Damage;
                    player.Health -= goblinKing.Damage;
                    System.Console.WriteLine("         Your Attack Successful");
                    Thread.Sleep(2000);
                    if(enemySkillActive > 7)
                    {
                        goblinKing.Damage += 1;
                    }
                    continue;
                }
                if (yourChoice == 2 && enemyChoice == 1)
                {
                    System.Console.WriteLine($"           You Choose Defense");
                    System.Console.WriteLine($"    {goblinKing.Name} Choose Attack {player.Name}");
                    Thread.Sleep(2000);
                    Random random = new Random();
                    var defendChange = random.Next(10)+1;
                    if(defendChange > 5)
                    {
                        System.Console.WriteLine("         Your Defense Failed");
                        player.Health -= goblinKing.Damage;                    
                        if(enemySkillActive > 7)
                        {
                            goblinKing.Damage += 1;
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
                    System.Console.WriteLine($"     You choose attack {goblinKing.Name}");
                    System.Console.WriteLine($"     {goblinKing.Name} choose defend");
                    Thread.Sleep(2000);
                    Random random = new Random();
                    var defendChange = random.Next(10)+1;
                    if(defendChange > 5)
                    {
                        System.Console.WriteLine($"    {goblinKing.Name} Defense Failed");
                        goblinKing.Health -= player.Damage;
                        Thread.Sleep(2000);
                        continue;
                    }
                    if(defendChange <= 5)
                    {
                        System.Console.WriteLine($"      {goblinKing.Name} Defense Successful");
                        Thread.Sleep(2000);
                        continue;
                    }
                }
                if(yourChoice == 2 && enemyChoice == 2)
                {
                    System.Console.WriteLine($"     You choose defend");
                    System.Console.WriteLine($"    {goblinKing.Name} choose defend");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            if(player.Health <= 0)
            {
                var stringNull = fight.PlayerDied();
                
            }

            if(goblinKing.Health <= 10)
            {                                
                Console.Clear();
                Console.WriteLine($"                                 You Have Defeated {goblinKing.Name}");           
                Console.ReadKey();                                         
            }
        }        
    }
}