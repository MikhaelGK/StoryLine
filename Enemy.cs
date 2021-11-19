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
            Skill = "Fair Ball";            
        }
        public void Goblin()
        {
            Health = 500;
            Skill = "Thief";            
        }        
    }
}