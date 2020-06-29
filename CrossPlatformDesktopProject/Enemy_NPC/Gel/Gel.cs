using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Gel : AbstractNPC
    {

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyGround;
            set => _ = Enumerations.GameObjectType.EnemyGround;
        }

        public Gel()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGel();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.GelDamageAmount;
            MaxHP = Constant.GelHP;
            CurrentHP = MaxHP;
        }


    }
}
