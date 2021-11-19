using System;

namespace StoryLine
{
    public class Player : Entity
    {
        public string _name { get; set; }        
                
        public Player(string name)
        {
            _name = name;
            Health = 100;    
            
        }
    }
}