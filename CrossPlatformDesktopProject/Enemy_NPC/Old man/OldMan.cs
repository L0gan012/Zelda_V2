using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class OldMan : AbstractNPC
    {

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.EnemyGround;

        public OldMan()
        {
            Sprite = NPCSpriteFactory.Instance.CreateNPCOldMan();
            Position = Constant.EnemyStartPosition;

            DamageAmount = EnemyConstants.OldManDamageAmount;
            MaxHP = EnemyConstants.OldManHP;
            CurrentHP = MaxHP;
        }

        public override void TakeDamage(float damageAmount)
        {
            //don't hurt the old man
        }
    }
}
