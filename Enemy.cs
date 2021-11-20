using System;

namespace StoryLine
{
    public class Enemy : Entity
    {        
        public Enemy(string name, int health, string skill, string weapon, int damage)
        {
            Name = name;
            Health = health;
            Skill = skill;
            Weapon = weapon;
            Damage = damage;

        }
    }
}