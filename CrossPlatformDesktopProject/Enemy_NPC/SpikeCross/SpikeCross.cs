using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class SpikeCross : AbstractNPC
    {
        private bool forward;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public SpikeCross()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemySpikeCross();
            Position = Constant.EnemyStartPosition;
            forward = true;

            DamageAmount = Constant.GelDamageAmount;
            MaxHP = Constant.GelHP;
            CurrentHP = MaxHP;
        }
    }
}
