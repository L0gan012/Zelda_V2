using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class Stalfos : AbstractNPC
    {
        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Stalfos()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyStalfos();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.StalfosDamageAmount;
            MaxHP = Constant.StalfosHP;
            CurrentHP = MaxHP;
        }
    }
}
