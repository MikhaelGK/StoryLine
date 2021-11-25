using System;

namespace StoryLine
{
    public class FightWithRoyaleMinion : Fight
    {
        public void FightRoyaleMinion(Enemy RoyaleMinion, Player player)
        {
            FightEnemy(RoyaleMinion, player);            
        }
    }
}