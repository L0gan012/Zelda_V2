using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class SpikeCross : AbstractNPC
    {

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public SpikeCross()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemySpikeCross();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.SpikeCrossDamageAmount;
            MaxHP = Constant.SpikeCrossHP;
            CurrentHP = MaxHP;
        }
    }
}
