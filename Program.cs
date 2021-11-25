using System;

namespace StoryLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BeginningOfTheStory beginningOfTheStory = new BeginningOfTheStory();
            MiddleOfTheStory middleOfTheStory = new MiddleOfTheStory();
            FinalOfTheStory finalOfTheStory = new FinalOfTheStory();
            Player player = new Player();

            beginningOfTheStory.Start(player);                   
            middleOfTheStory.ContinueChapter(player); 
            finalOfTheStory.AfterChooseTheWeapon(player);           
        }
    }
}