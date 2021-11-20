using System;

namespace StoryLine
{
    public class Enemy : Entity
    {
        public void Dragon()
        {
            Health = 20000;
            Skill = "Dragon Breath";            
        }
        public void RoyaleMinion()
        {
            Health = 500;
            Skill = "Fire Ball";            
        }
        public void Goblin()
        {
            Health = 500;
            Skill = "Thief";            
        } 
        public void Wugiwugi()
        {
            Health = 500;
            Skill = "Eat human";            
        }        
    }
}