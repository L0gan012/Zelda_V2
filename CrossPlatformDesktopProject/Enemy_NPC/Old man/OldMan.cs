using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class OldMan : AbstractNPC
    {

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
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
