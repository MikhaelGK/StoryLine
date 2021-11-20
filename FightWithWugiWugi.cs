using System;

namespace StoryLine
{
    public class FightWithWugiWugi
    {
        public void FightWugiWugi(Enemy wugiwugi, Player player)
        {         
            if(wugiwugi.Health == 0)
            {
                Story story = new Story();
                story.AfterDefeatWugiWugi(wugiwugi, player);
            }

            Console.Clear();
            System.Console.WriteLine($"{wugiwugi.Name}'s Health : {wugiwugi.Health}");
            System.Console.WriteLine($"{wugiwugi.Name}'s Skill  : {wugiwugi.Skill}");
            System.Console.WriteLine($"{wugiwugi.Name}'s Weapon : {wugiwugi.Weapon}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Hp    : {player.Health}");
            System.Console.WriteLine($"Armor : {player.Armor}");
            System.Console.WriteLine($"WP    : {player.Weapon}");
            System.Console.WriteLine();            

            var enemySkillActive = EnemySkillChance();            
            if(enemySkillActive > 7)            
                System.Console.WriteLine($"{wugiwugi.Name}'s Skill activated");

            System.Console.WriteLine("1. Attack");
            System.Console.WriteLine("2. Defense");                        
            var stringNull = Console.ReadLine();
            if(stringNull == "")
            {
                FightWugiWugi(wugiwugi, player);
            }
            var enemyChoice = EnemyAttackChance();
            var yourChoice = Convert.ToInt32(stringNull);
            if (yourChoice == 1 && enemyChoice == 1)
            {
                System.Console.WriteLine($"     You Choose Attack {wugiwugi.Name}");
                System.Console.WriteLine($"    {wugiwugi.Name} Choose Attack {player.Name}");
                wugiwugi.Health -= player.Damage;
                player.Health -= wugiwugi.Damage;
                System.Console.WriteLine("      Your Attack Successful");
                Console.ReadKey();
                if(enemySkillActive > 7)
                {
                    wugiwugi.Damage += 1;
                }
                FightWugiWugi(wugiwugi, player);                
            }
            if (yourChoice == 2 && enemyChoice == 1)
            {
                System.Console.WriteLine($"           You Choose Defense");
                System.Console.WriteLine($"    {wugiwugi.Name} Choose Attack {player.Name}");
                Random random = new Random();
                var defendChange = random.Next(10)+1;
                if(defendChange > 5)
                {
                    System.Console.WriteLine("      Your Defense Failed");
                    player.Health -= wugiwugi.Damage;                    
                    if(enemySkillActive > 7)
                    {
                        wugiwugi.Damage += 1;
                    }                    
                    Console.ReadKey();
                    FightWugiWugi(wugiwugi, player);
                }
                if(defendChange <= 5)
                {
                    System.Console.WriteLine("      Your Defense Successful");
                    Console.ReadKey();
                    FightWugiWugi(wugiwugi, player);
                }
            }
            if(yourChoice == 1 && enemyChoice == 2)
            {
                System.Console.WriteLine($"     You choose attack {wugiwugi.Name}");
                System.Console.WriteLine($"    {wugiwugi.Name} choose defend");
                Random random = new Random();
                var defendChange = random.Next(10)+1;
                if(defendChange > 5)
                {
                    System.Console.WriteLine($"      {wugiwugi.Name} Defense Failed");
                    wugiwugi.Health -= player.Damage;
                    Console.ReadKey();                    
                    FightWugiWugi(wugiwugi, player);
                }
                if(defendChange <= 5)
                {
                    System.Console.WriteLine($"      {wugiwugi.Name} Defense Successful");
                    Console.ReadKey();
                    FightWugiWugi(wugiwugi, player);
                }
            }
            if(yourChoice == 2 && enemyChoice == 2)
            {
                System.Console.WriteLine($"     You choose defend");
                System.Console.WriteLine($"    {wugiwugi.Name} choose defend");
                Console.ReadKey();
                FightWugiWugi(wugiwugi, player);
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
    }
}