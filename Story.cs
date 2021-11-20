using System;

namespace StoryLine
{
    public class Story
    {        
        public void Start()
        {
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine(" Welcome To StoryLine");
            System.Console.WriteLine();
            System.Console.WriteLine("Press Start To Continue");
            Console.ReadKey();
            Prolog();            
        }

        public void Prolog()
        {
            Console.Clear();
            System.Console.WriteLine("One day, there was a mountain called Mount Sirius which there were many treasures, but there is a dragon guarding the mountain");
            System.Console.WriteLine("          Many warrior have try to get the treasure, but they never come back after go to the mountain");
            System.Console.WriteLine();
            Console.ReadKey();            
            System.Console.WriteLine("            You are a very poor person who has been frustrated. One day, you hear about Mount Sirius.");
            System.Console.WriteLine("                               Because you want to be rich, you go to the mountains");
            Console.ReadKey();                        
            Main();
        }

        public void Main()
        {                       
            Console.Clear();
            System.Console.WriteLine("Morning");
            System.Console.WriteLine();
            System.Console.WriteLine("    You have wake up and go to road. There is a old man that ask your name");
            System.Console.Write("         Enter Your Name : ");            
            var name = Console.ReadLine();
            if(name == null)
                Main();
            else if(name == "")
                Main();
            else
            {
                Player player = new Player(name);  
                StoryAfterPlayerName(player);                              
            }
        }

        public void StoryAfterPlayerName(Player player)
        {
            var name = player.Name;

            System.Console.WriteLine();            
            System.Console.WriteLine($"Old Man : {name}?? It's a beautiful name");
            Console.ReadKey();
            System.Console.WriteLine($"Old Man : Have you ever heard about Mount Sirius?");
            Console.ReadKey();
            System.Console.WriteLine();
            System.Console.WriteLine("1. I have heard about it");
            System.Console.WriteLine("2. No, I never heard of it");
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            if(stringNull == "")
            {
                StoryAfterPlayerName(player);
            }
            var yourChoice = Convert.ToInt32(stringNull);
            Console.Clear();
            if(yourChoice == 1)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Old Man : I will give you some pointers if you want to go there");
                Console.ReadKey();
                System.Console.WriteLine("You     : What is the pointers?");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : Never be greedy");
                Console.ReadKey();
                System.Console.WriteLine("You     : What do you mean? You said that is a clue?");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : you'll know what I mean soon");
                Console.ReadKey();
                PrepareToGoToTheMountain(player);
            }
            if(yourChoice == 2)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Old Man : There is a mountain that called Mount Sirius which there were many treasure and there is a dragon guarding the mountain");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : Many warrior have try to the treasure, but they never come back after go to the mountain");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : So, What do you think about Mount Sirius?");
                Console.ReadKey();
                System.Console.WriteLine("You     : Very Interesting");     
                Console.ReadKey();            
                System.Console.WriteLine("Old Man : I will give you some pointers if you want to go there");
                Console.ReadKey();
                System.Console.WriteLine("You     : What is the pointers?");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : Never be greedy");
                Console.ReadKey();
                System.Console.WriteLine("You     : What do you mean? You said that is a clue?");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : you'll know what I mean soon");
                Console.ReadKey();           
                PrepareToGoToTheMountain(player);
            }
        }

        public void PrepareToGoToTheMountain(Player player)
        {
            Console.Clear();
            System.Console.WriteLine("Go Home");
            Console.ReadKey();
            System.Console.WriteLine("                  When you're at home, you prepare your equipment to go to Mount Sirius");
            System.Console.WriteLine("                            Once you are ready, you see the knife and the bow");
            System.Console.WriteLine();
            Console.ReadKey();
            System.Console.WriteLine("1. Pick up the knife");
            System.Console.WriteLine("2. Pick up the bow");            
            System.Console.Write("");
            var yourChoice = Convert.ToInt32(Console.ReadLine());            
            if(yourChoice == 1)
            {
                player.Weapon = "Knife";                                                                
                System.Console.WriteLine($"                               You pick the {player.Weapon}");
                player.Damage = 10;
                Console.ReadKey();
                GoToTheForest(player);
            }
            if(yourChoice == 2)
            {
                player.Weapon = "Bow";
                System.Console.WriteLine($"                               You pick the {player.Weapon}");
                player.Damage = 15;
                Console.ReadKey();
                GoToTheForest(player);
            }            
        }

        public void GoToTheForest(Player player)
        {
            Enemy wugiwugi = new Enemy("Wugi-Wugi", 100, "Every hit human will increase his damage by 1", "Wooden Sword", 7);                        

            Console.Clear();
            System.Console.WriteLine("Arendelle Forest");
            System.Console.WriteLine();
            System.Console.WriteLine("      When you are in the forest, you meet a wugi-wugi");
            System.Console.WriteLine();
            Console.ReadKey();
            System.Console.WriteLine("Wugi-Wugi : (laugh) ekk.. ekh.. ");
            Console.ReadKey();
            System.Console.WriteLine("You       : Who the hell are you?");
            Console.ReadKey();
            System.Console.WriteLine("Wugi-Wugi : I'm Wugi-Wugi");
            Console.ReadKey();
            System.Console.WriteLine("Wugi-Wugi : It's a long time no see human in this forest");
            Console.ReadKey();
            System.Console.WriteLine("Wugi-Wugi : Have you ready to died in here? (laugh)");
            Console.ReadKey();
            System.Console.WriteLine();
            System.Console.WriteLine("Your Mision : Defeated Wugi-Wugi");            
            System.Console.WriteLine("Wugi-Wugi :");
            System.Console.WriteLine($"   The damage dealt is {wugiwugi.Damage}");
            System.Console.WriteLine($"   {wugiwugi.Skill}");
            
            FightWithWugiWugi Fight = new FightWithWugiWugi();
            Fight.FightWugiWugi(wugiwugi, player);
        }

        public void AfterDefeatWugiWugi(Enemy wugiwugi, Player player)
        {
            Console.Clear();
        }                
    }   
}