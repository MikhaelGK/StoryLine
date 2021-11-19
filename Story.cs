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
            System.Console.WriteLine("One day, there was a mountain which there were many treasures, but there is a dragon guarding the mountain");
            System.Console.WriteLine("    Many warrior have try to get the treasure, but they never come back after go to that mountain");
            Console.ReadKey();            
        }
    }   
}