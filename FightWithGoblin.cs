using System;

namespace StoryLine
{
    public class FightWithGoblin
    {
        public void FightGoblin(Enemy huggywuggy, Player player)
        {         
            Fight fight = new Fight();
            while(huggywuggy.Health > 0 && player.Health > 0)
            {                                             
                var enemySkillActive = fight.EnemySkillChance();            
                var stringNull = fight.Information(huggywuggy, player, enemySkillActive);
                if(stringNull == "" || stringNull != "2" && stringNull != "1")
                {
                    continue;                   
                }
                var enemyChoice = fight.EnemyAttackChance();
                var yourChoice = Convert.ToInt32(stringNull);
                if (yourChoice == 1 && enemyChoice == 1)
                {
                    System.Console.WriteLine($"     You Choose Attack {huggywuggy.Name}");
                    System.Console.WriteLine($"    {huggywuggy.Name} Choose Attack {player.Name}");
                    huggywuggy.Health -= player.Damage;
                    player.Health -= huggywuggy.Damage;
                    System.Console.WriteLine("         Your Attack Successful");
                    Thread.Sleep(2000);
                    if(enemySkillActive > 7)
                    {
                        huggywuggy.Damage += 1;
                    }
                    continue;
                }
                if (yourChoice == 2 && enemyChoice == 1)
                {
                    System.Console.WriteLine($"           You Choose Defense");
                    System.Console.WriteLine($"    {huggywuggy.Name} Choose Attack {player.Name}");
                    Thread.Sleep(2000);
                    Random random = new Random();
                    var defendChange = random.Next(10)+1;
                    if(defendChange > 5)
                    {
                        System.Console.WriteLine("         Your Defense Failed");
                        player.Health -= huggywuggy.Damage;                    
                        if(enemySkillActive > 7)
                        {
                            huggywuggy.Damage += 1;
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
                    System.Console.WriteLine($"     You choose attack {huggywuggy.Name}");
                    System.Console.WriteLine($"     {huggywuggy.Name} choose defend");
                    Thread.Sleep(2000);
                    Random random = new Random();
                    var defendChange = random.Next(10)+1;
                    if(defendChange > 5)
                    {
                        System.Console.WriteLine($"    {huggywuggy.Name} Defense Failed");
                        huggywuggy.Health -= player.Damage;
                        Thread.Sleep(2000);
                        continue;
                    }
                    if(defendChange <= 5)
                    {
                        System.Console.WriteLine($"      {huggywuggy.Name} Defense Successful");
                        Thread.Sleep(2000);
                        continue;
                    }
                }
                if(yourChoice == 2 && enemyChoice == 2)
                {
                    System.Console.WriteLine($"     You choose defend");
                    System.Console.WriteLine($"    {huggywuggy.Name} choose defend");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            if(player.Health <= 0)
            {
                var stringNull = fight.PlayerDied();
                
            }

            if(huggywuggy.Health <= 0)
            {
                BeginningOfTheStory story = new BeginningOfTheStory();
                Console.Clear();
                Console.WriteLine("                                 You Have Defeated Huggy Wuggy");           
                Console.ReadKey();                
                story.AfterDefeatHuggyWuggy(huggywuggy, player);            
            }
        }        
    }
}