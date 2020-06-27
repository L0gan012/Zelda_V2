using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Gel : AbstractNPC
    {

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
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
