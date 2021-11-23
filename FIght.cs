using System;

namespace StoryLine
{
    public class Fight
    {
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

        public string? Information(Enemy enemy, Player player, int enemySkillActive)
        {
            Console.Clear();
            System.Console.WriteLine($"{enemy.Name}'s Health : {enemy.Health}");
            System.Console.WriteLine($"{enemy.Name}'s Skill  : {enemy.Skill}");
            System.Console.WriteLine($"{enemy.Name}'s Weapon : {enemy.Weapon}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Hp    : {player.Health}");
            System.Console.WriteLine($"Armor : {player.Armor}");
            System.Console.WriteLine($"WP    : {player.Weapon}");
            System.Console.WriteLine();            

            if(enemy.Skill != "")    
                if(enemySkillActive > 7)            
                    System.Console.WriteLine($"{enemy.Name}'s Skill activated");

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