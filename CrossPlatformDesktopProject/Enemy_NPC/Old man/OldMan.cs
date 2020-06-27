using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class OldMan : AbstractNPC
    {
        private ISprite sprite;
        private Vector2 location;
        private Color color;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public OldMan()
        {
            sprite = NPCSpriteFactory.Instance.CreateNPCOldMan();
            location = Constant.EnemyStartPosition;
            color = Color.White;

            DamageAmount = Constant.GelDamageAmount;
            MaxHP = Constant.GelHP;
            CurrentHP = MaxHP;
        }

    }
}
