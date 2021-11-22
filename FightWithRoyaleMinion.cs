using System;

namespace StoryLine
{
    public class FightWithRoyaleMinion
    {
        public void FightRoyaleMinion(Enemy RoyaleMinion, Player player)
        {  
            if(RoyaleMinion.Health <= 0)
            {
                BeginningOfTheStory story = new BeginningOfTheStory();
            }

            Console.Clear();
            System.Console.WriteLine($"{RoyaleMinion.Name}'s Health : {RoyaleMinion.Health}");
            System.Console.WriteLine($"{RoyaleMinion.Name}'s Skill  : {RoyaleMinion.Skill}");
            System.Console.WriteLine($"{RoyaleMinion.Name}'s Weapon : {RoyaleMinion.Weapon}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Hp    : {player.Health}");
            System.Console.WriteLine($"Armor : {player.Armor}");
            System.Console.WriteLine($"WP    : {player.Weapon}");
            System.Console.WriteLine(); 

            var enemySkillActive = EnemySkillChance();            
            if(enemySkillActive > 7)            
                System.Console.WriteLine($"{RoyaleMinion.Name}'s Skill activated");

            System.Console.WriteLine("1. Attack");
            System.Console.WriteLine("2. Defense");                        
            var stringNull = Console.ReadLine();
            if(stringNull == "")
            {
                FightRoyaleMinion(RoyaleMinion, player);
            }
            var enemyChoice = EnemyAttackChance();
            var yourChoice = Convert.ToInt32(stringNull);
            if (yourChoice == 1 && enemyChoice == 1)
            {
                System.Console.WriteLine($"     You Choose Attack {RoyaleMinion.Name}");
                System.Console.WriteLine($"    {RoyaleMinion.Name} Choose Attack {player.Name}");
                RoyaleMinion.Health -= player.Damage;
                player.Health -= RoyaleMinion.Damage;
                System.Console.WriteLine("      Your Attack Successful");
                Console.ReadKey();
                if(enemySkillActive > 7)
                {
                    RoyaleMinion.Damage += 1;
                }
                FightRoyaleMinion(RoyaleMinion, player);                
            }
            if (yourChoice == 2 && enemyChoice == 1)
            {
                System.Console.WriteLine($"           You Choose Defense");
                System.Console.WriteLine($"    {RoyaleMinion.Name} Choose Attack {player.Name}");
                Random random = new Random();
                var defendChange = random.Next(10)+1;
                if(defendChange > 5)
                {
                    System.Console.WriteLine("      Your Defense Failed");
                    player.Health -= RoyaleMinion.Damage;                    
                    if(enemySkillActive > 7)
                    {
                        RoyaleMinion.Damage += 1;
                    }                    
                    Console.ReadKey();
                    FightRoyaleMinion(RoyaleMinion, player);
                }
                if(defendChange <= 5)
                {
                    System.Console.WriteLine("      Your Defense Successful");
                    Console.ReadKey();
                    FightRoyaleMinion(RoyaleMinion, player);
                }
            }
            if(yourChoice == 1 && enemyChoice == 2)
            {
                System.Console.WriteLine($"     You choose attack {RoyaleMinion.Name}");
                System.Console.WriteLine($"    {RoyaleMinion.Name} choose defend");
                Random random = new Random();
                var defendChange = random.Next(10)+1;
                if(defendChange > 5)
                {
                    System.Console.WriteLine($"      {RoyaleMinion.Name} Defense Failed");
                    RoyaleMinion.Health -= player.Damage;
                    Console.ReadKey();                    
                    FightRoyaleMinion(RoyaleMinion, player);
                }
                if(defendChange <= 5)
                {
                    System.Console.WriteLine($"      {RoyaleMinion.Name} Defense Successful");
                    Console.ReadKey();
                    FightRoyaleMinion(RoyaleMinion, player);
                }
            }
            if(yourChoice == 2 && enemyChoice == 2)
            {
                System.Console.WriteLine($"     You choose defend");
                System.Console.WriteLine($"    {RoyaleMinion.Name} choose defend");
                Console.ReadKey();
                FightRoyaleMinion(RoyaleMinion, player);
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