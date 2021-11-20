using System;

namespace StoryLine
{
    public class FightWithgoblin
    {
        public void Fightgoblin(Enemy Goblin, Player player)
        {
            Console.Clear();
            System.Console.WriteLine($"{Goblin.Name}'s Health : {Goblin.Health}");
            System.Console.WriteLine($"{Goblin.Name}'s Skill  : {Goblin.Skill}");
            System.Console.WriteLine($"{Goblin.Name}'s Weapon : {Goblin.Weapon}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Hp    : {player.Health}");
            System.Console.WriteLine($"Armor : {player.Armor}");
            System.Console.WriteLine($"WP    : {player.Weapon}");
            System.Console.WriteLine();            

            var enemySkillActive = EnemySkillChance();            
            if(enemySkillActive > 7)            
                System.Console.WriteLine($"{Goblin.Name}'s Skill activated");

            System.Console.WriteLine("1. Attack");
            System.Console.WriteLine("2. Defense");                        
            var stringNull = Console.ReadLine();
            if(stringNull == "")
            {
                Fightgoblin(Goblin, player);
            }
            var enemyChoice = EnemyAttackChance();
            var yourChoice = Convert.ToInt32(stringNull);
            if (yourChoice == 1 && enemyChoice == 1)
            {
                System.Console.WriteLine($"     You Choose Attack {Goblin.Name}");
                System.Console.WriteLine($"    {Goblin.Name} Choose Attack {player.Name}");
                Goblin.Health -= player.Damage;
                player.Health -= Goblin.Damage;
                System.Console.WriteLine("      Your Attack Successful");
                Console.ReadKey();
                if(enemySkillActive > 7)
                {
                    Goblin.Damage += 1;
                }
                Fightgoblin(Goblin, player);                
            }
            if (yourChoice == 2 && enemyChoice == 1)
            {
                System.Console.WriteLine($"           You Choose Defense");
                System.Console.WriteLine($"    {Goblin.Name} Choose Attack {player.Name}");
                Random random = new Random();
                var defendChange = random.Next(10)+1;
                if(defendChange > 5)
                {
                    System.Console.WriteLine("      Your Defense Failed");
                    player.Health -= Goblin.Damage;                    
                    if(enemySkillActive > 7)
                    {
                        Goblin.Damage += 1;
                    }                    
                    Console.ReadKey();
                    Fightgoblin(Goblin, player);
                }
                if(defendChange <= 5)
                {
                    System.Console.WriteLine("      Your Defense Successful");
                    Console.ReadKey();
                    Fightgoblin(Goblin, player);
                }
            }
            if(yourChoice == 1 && enemyChoice == 2)
            {
                System.Console.WriteLine($"     You choose attack {Goblin.Name}");
                System.Console.WriteLine($"    {Goblin.Name} choose defend");
                Random random = new Random();
                var defendChange = random.Next(10)+1;
                if(defendChange > 5)
                {
                    System.Console.WriteLine($"      {Goblin.Name} Defense Failed");
                    Goblin.Health -= player.Damage;
                    Console.ReadKey();                    
                    Fightgoblin(Goblin, player);
                }
                if(defendChange <= 5)
                {
                    System.Console.WriteLine($"      {Goblin.Name} Defense Successful");
                    Console.ReadKey();
                    Fightgoblin(Goblin, player);
                }
            }
            if(yourChoice == 2 && enemyChoice == 2)
            {
                System.Console.WriteLine($"     You choose defend");
                System.Console.WriteLine($"    {Goblin.Name} choose defend");
                Console.ReadKey();
                Fightgoblin(Goblin, player);
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