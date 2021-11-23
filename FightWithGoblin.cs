using System;

namespace StoryLine
{
    public class FightWithGoblin
    {
        public void FightGoblin(Enemy goblin, Enemy elderGoblin, Enemy goblinKing, Player player)
        {         
            Fight fight = new Fight();
            while(goblin.Health > 0 && player.Health > 0)
            {                                             
                var enemySkillActive = fight.EnemySkillChance();            
                var stringNull = fight.Information(goblin, player, enemySkillActive);
                if(stringNull == "" || stringNull != "2" && stringNull != "1")
                {
                    continue;                   
                }
                var enemyChoice = fight.EnemyAttackChance();
                var yourChoice = Convert.ToInt32(stringNull);
                if (yourChoice == 1 && enemyChoice == 1)
                {
                    System.Console.WriteLine($"     You Choose Attack {goblin.Name}");
                    System.Console.WriteLine($"    {goblin.Name} Choose Attack {player.Name}");
                    goblin.Health -= player.Damage;
                    player.Health -= goblin.Damage;
                    System.Console.WriteLine("         Your Attack Successful");
                    Thread.Sleep(2000);
                    if(enemySkillActive > 7)
                    {
                        goblin.Damage += 1;
                    }
                    continue;
                }
                if (yourChoice == 2 && enemyChoice == 1)
                {
                    System.Console.WriteLine($"           You Choose Defense");
                    System.Console.WriteLine($"    {goblin.Name} Choose Attack {player.Name}");
                    Thread.Sleep(2000);
                    Random random = new Random();
                    var defendChange = random.Next(10)+1;
                    if(defendChange > 5)
                    {
                        System.Console.WriteLine("         Your Defense Failed");
                        player.Health -= goblin.Damage;                    
                        if(enemySkillActive > 7)
                        {
                            goblin.Damage += 1;
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
                    System.Console.WriteLine($"     You choose attack {goblin.Name}");
                    System.Console.WriteLine($"     {goblin.Name} choose defend");
                    Thread.Sleep(2000);
                    Random random = new Random();
                    var defendChange = random.Next(10)+1;
                    if(defendChange > 5)
                    {
                        System.Console.WriteLine($"    {goblin.Name} Defense Failed");
                        goblin.Health -= player.Damage;
                        Thread.Sleep(2000);
                        continue;
                    }
                    if(defendChange <= 5)
                    {
                        System.Console.WriteLine($"      {goblin.Name} Defense Successful");
                        Thread.Sleep(2000);
                        continue;
                    }
                }
                if(yourChoice == 2 && enemyChoice == 2)
                {
                    System.Console.WriteLine($"     You choose defend");
                    System.Console.WriteLine($"    {goblin.Name} choose defend");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            if(player.Health <= 0)
            {
                var stringNull = fight.PlayerDied();
                
            }

            if(goblin.Health <= 0)
            {                
                FightWithElderGoblin fightElderGoblin = new FightWithElderGoblin();
                Console.Clear();
                Console.WriteLine($"                                 You Have Defeated {goblin.Name}");           
                Console.ReadKey();                
                fightElderGoblin.FightElderGoblin(elderGoblin, goblinKing, player);            
            }
        }        
    }
}