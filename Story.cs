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
            System.Console.WriteLine("          Many warrior have try to get the treasure, but they never come back after go to that mountain");
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
            var name = player._name;

            System.Console.WriteLine();            
            System.Console.WriteLine($"Old Man : {name}?? It's a beautiful name");
            Console.ReadKey();
            System.Console.WriteLine($"Old Man : Have you ever heard about Mount Sirius?");
            Console.ReadKey();
            System.Console.WriteLine();
            System.Console.WriteLine("1. I have heard about it");
            System.Console.WriteLine("2. No, I never heard of it");
            System.Console.WriteLine();
            var yourChoice = Convert.ToInt32(Console.ReadLine());
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
                System.Console.WriteLine("You     : What do you mean? You said that is the clue?");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : you'll know what I mean soon");
                Console.ReadKey();
            }
            if(yourChoice == 2)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Old Man : ");
            }
        }
    }   
}