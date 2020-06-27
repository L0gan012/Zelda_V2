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
            Color = Color.White;
            DamageAmount = Constant.GelDamageAmount;
            maxHP = Constant.GelHP;
            currentHP = maxHP;
        }


    }
}
