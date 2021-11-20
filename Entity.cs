using System;

namespace StoryLine
{
    public class Entity
    {
        public string? Name { get; set; }
        public int Health { get; set; }
        public string? Skill { get; set; }
        public string? Weapon { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; } = 0;
    }
}