using System;

namespace StoryLine
{
    public class FightWithHuggyWuggy
    {
        public void FightHuggyWuggy(Enemy huggywuggy, Player player)
        {         
            while(huggywuggy.Health > 0 && player.Health > 0)
            {                                             
                var enemySkillActive = EnemySkillChance();            
                var stringNull = Information(huggywuggy, player, enemySkillActive);
                if(stringNull == "" || stringNull != "2" && stringNull != "1")
                {
                    continue;                   
                }
                var enemyChoice = EnemyAttackChance();
                var yourChoice = Convert.ToInt32(stringNull);
                if (yourChoice == 1 && enemyChoice == 1)
                {
                    System.Console.WriteLine($"     You Choose Attack {huggywuggy.Name}");
                    System.Console.WriteLine($"    {huggywuggy.Name} Choose Attack {player.Name}");
                    huggywuggy.Health -= player.Damage;
                    player.Health -= huggywuggy.Damage;
                    System.Console.WriteLine("      Your Attack Successful");
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
                        System.Console.WriteLine("      Your Defense Failed");
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
                        System.Console.WriteLine("      Your Defense Successful");
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
                var stringNull = PlayerDied();
                
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

        public int EnemyAttackChance()
        {
            Random random = new Random();
            var attackEnemyChance = random.Next(2) + 1;
            return attackEnemyChance;
        }        

        public int EnemySkillChance()
        {
            Random random = new Random();
            var enemySkillChance = random.Next(10) + 1;
            return enemySkillChance;            
        }        

        public string? Information(Enemy huggywuggy, Player player, int enemySkillActive)
        {
            Console.Clear();
            System.Console.WriteLine($"{huggywuggy.Name}'s Health : {huggywuggy.Health}");
            System.Console.WriteLine($"{huggywuggy.Name}'s Skill  : {huggywuggy.Skill}");
            System.Console.WriteLine($"{huggywuggy.Name}'s Weapon : {huggywuggy.Weapon}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Hp    : {player.Health}");
            System.Console.WriteLine($"Armor : {player.Armor}");
            System.Console.WriteLine($"WP    : {player.Weapon}");
            System.Console.WriteLine();            
                    
            if(enemySkillActive > 7)            
                System.Console.WriteLine($"{huggywuggy.Name}'s Skill activated");

            System.Console.WriteLine("1. Attack");
            System.Console.WriteLine("2. Defense");                        
            var stringNull = Console.ReadLine();
            return stringNull;
        }

        public string? PlayerDied()
        {
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("                       You Died");
            Thread.Sleep(5000);
            Console.Clear();         
            System.Console.WriteLine();   
            System.Console.WriteLine("                 Do You Want To Restart?");
            System.Console.WriteLine("                 1. Yes           2.No");
            var stringNull = Console.ReadLine();
            return stringNull;
        }
    }
}