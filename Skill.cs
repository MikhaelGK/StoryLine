using System;

namespace StoryLine
{
    public class Skill
    {
        public string HuggyWuggy { get; set; } = "Every hit human will increase his damage by 1";        
        public string RoyaleMinion { get; set; } = "Meteor Ball";
        public string FirstSkill { get; set; } = "Strength Enhance : Enhance your strength by 25 every your skill active";
        public string SecondSkill { get; set; } = "Lifesteal : Heals 50% of current health after attack the enemy";
        public string ThirdSkill { get; set; } = "Perfect Defense : Immune to every enemy attack";

        public void EnemySkillAction(Enemy enemy)
        {
            if(enemy.Skill == HuggyWuggy)
            {
                enemy.Damage += 1;                                
            }        
            if(enemy.Skill == RoyaleMinion)
            {
                enemy.Damage = 40;
            }                       
        }

        public void EndEnemySkillAction(Enemy enemy)
        {
            if(enemy.Skill == RoyaleMinion)
            {
                enemy.Damage = 30;
            }
        }

        public void PlayerFirstSkillAction(Player player)
        {
            if(player.Skill == FirstSkill)
            {
                player.Damage += 25;                
            }            
        }

        public void EndPlayerFirstSkillAction(Player player)
        {
            if(player.Skill == FirstSkill)
            {
                player.Damage -= 25;
            }
        }

        public void PlayerSecondSkillAction(Player player)
        {
            if(player.Skill == SecondSkill)
            {
                var recovery = player.Health / 2;
                player.Health += recovery;
            }
        }

        public int PlayerThirdSkillAction()
        {
            var defendChange = 10;
            return defendChange;
        }
    }
}