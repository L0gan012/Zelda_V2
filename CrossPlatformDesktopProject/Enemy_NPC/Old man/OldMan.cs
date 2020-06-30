using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class OldMan : AbstractNPC
    {

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyGround;
            set => _ = Enumerations.GameObjectType.EnemyGround;
        }

        public OldMan()
        {
            Sprite = NPCSpriteFactory.Instance.CreateNPCOldMan();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.OldManDamageAmount;
            MaxHP = Constant.OldManHP;
            CurrentHP = MaxHP;
        }

    }
}
