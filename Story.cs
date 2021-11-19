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
            System.Console.Write("                           ");            
        }
    }   
}