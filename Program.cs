using System;

namespace StoryLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BeginningOfTheStory beginningOfTheStory = new BeginningOfTheStory();
            MiddleOfTheStory middleOfTheStory = new MiddleOfTheStory();
            Player player = new Player();

            beginningOfTheStory.Start(player);                   
            middleOfTheStory.ContinueChapter(player);
        }
    }
}