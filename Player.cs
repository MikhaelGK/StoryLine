using System;

namespace StoryLine
{
    public class Player : Entity
    {                                      
        public Player(string name)
        {
            Name = name;
            Health = 100;                    
        }        
    }
}