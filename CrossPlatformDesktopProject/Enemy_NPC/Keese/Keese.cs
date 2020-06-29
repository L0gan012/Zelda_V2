using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class Keese : AbstractNPC
    {

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyFlying;
            set => _ = Enumerations.GameObjectType.EnemyFlying;
        }

        public Keese()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyKeese();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.KeeseDamageAmount;
            MaxHP = Constant.KeeseHP;
            CurrentHP = MaxHP;
        }
    }
}
