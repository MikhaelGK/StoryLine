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

        public int SkillChance()
        {
            Random random = new Random();
            var enemySkillChance = random.Next(10) + 1;
            return enemySkillChance;            
        }        

        public string? Information(Enemy enemy, Player player, int enemySkillActive, int playerSkillActive)
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

                    
            if(enemy.Skill == "Manipulation")
            {
                System.Console.WriteLine($"{enemy.Name}'s Skill will display when you defeated the {enemy.Name}");
            }
            else if(enemy.Skill != "")                    
                if(enemySkillActive > 7)
                        System.Console.WriteLine($"{enemy.Name}'s Skill Activated");
                    
            if(player.Skill != "")    
                if(playerSkillActive > 7)            
                    System.Console.WriteLine($"Your Skill Activated");

            System.Console.WriteLine("1. Attack");
            System.Console.WriteLine("2. Defense");                        
            var stringNull = Console.ReadLine();
            return stringNull;
        }

        public string? PlayerDied()
        {
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("                       Game Over");
            Console.ReadKey();
            Console.Clear();         
            System.Console.WriteLine();   
            System.Console.WriteLine("                 Do You Want To Restart?");
            System.Console.WriteLine("                 1. Yes           2.No");
            var stringNull = Console.ReadLine();
            return stringNull;
        }

        public void FightEnemy(Enemy enemy, Player player)
        {
            Skill skill = new Skill();            
            while(enemy.Health > 0 && player.Health > 0)
            {            
                var playerSkillActive = SkillChance();                                 
                var enemySkillActive = SkillChance();            
                var stringNull = Information(enemy, player, enemySkillActive, playerSkillActive);
                if(stringNull == "" || stringNull != "2" && stringNull != "1")
                {
                    continue;                   
                }                
                var enemyChoice = EnemyAttackChance();
                var yourChoice = Convert.ToInt32(stringNull);
                if(playerSkillActive > 7)
                {
                    skill.PlayerFirstSkillAction(player);                    
                }
                if (yourChoice == 1 && enemyChoice == 1)
                {
                    System.Console.WriteLine($"     You Choose Attack {enemy.Name}");
                    System.Console.WriteLine($"    {enemy.Name} Choose Attack {player.Name}");
                    enemy.Health -= player.Damage;
                    player.Health -= enemy.Damage;
                    System.Console.WriteLine("         Your Attack Successful");
                    Thread.Sleep(2000);
                    if(playerSkillActive > 7)
                    {
                        skill.PlayerSecondSkillAction(player);
                    }
                    if(enemySkillActive > 7)
                    {
                        skill.EnemySkillAction(enemy);
                    }                                    
                }
                if (yourChoice == 2 && enemyChoice == 1)
                {
                    System.Console.WriteLine($"           You Choose Defense");
                    System.Console.WriteLine($"    {enemy.Name} Choose Attack {player.Name}");
                    Thread.Sleep(2000);
                    Random random = new Random();
                    var defendChange = random.Next(10)+1;
                    if(playerSkillActive > 7)
                    {
                        defendChange = skill.PlayerThirdSkillAction();
                    }
                    if(defendChange < 5)
                    {
                        System.Console.WriteLine("         Your Defense Failed");
                        player.Health -= enemy.Damage;                    
                        if(enemySkillActive > 7)
                        {                            
                            skill.EnemySkillAction(enemy);
                        }                    
                        Thread.Sleep(2000);                        
                    }
                    if(defendChange >= 5)
                    {
                        System.Console.WriteLine("         Your Defense Successful");
                        Thread.Sleep(2000);                        
                    }
                }
                if(yourChoice == 1 && enemyChoice == 2)
                {
                    System.Console.WriteLine($"     You choose attack {enemy.Name}");
                    System.Console.WriteLine($"     {enemy.Name} choose defend");
                    Thread.Sleep(2000);
                    Random random = new Random();
                    var defendChange = random.Next(10)+1;
                    if(defendChange < 5)
                    {
                        System.Console.WriteLine($"    {enemy.Name} Defense Failed");
                        enemy.Health -= player.Damage;
                        if(playerSkillActive > 7)
                        {
                            skill.PlayerSecondSkillAction(player);
                        }
                        Thread.Sleep(2000);                        
                    }
                    if(defendChange >= 5)
                    {
                        System.Console.WriteLine($"     {enemy.Name} Defense Successful");
                        Thread.Sleep(2000);                                                
                    }
                }
                if(yourChoice == 2 && enemyChoice == 2)
                {
                    System.Console.WriteLine($"     You choose defend");
                    System.Console.WriteLine($"    {enemy.Name} choose defend");
                    Thread.Sleep(2000);                    
                }
                if(playerSkillActive > 7)
                {
                    skill.EndPlayerFirstSkillAction(player);
                }
                if(player.Health >=100)
                {
                    player.Health = 100;
                }
            }
            if(player.Health <= 0)
            {
                var stringNull = PlayerDied();
            }            
        }
    }
}