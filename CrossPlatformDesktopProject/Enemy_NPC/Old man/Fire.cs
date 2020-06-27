using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class Fire : AbstractGameObject, INPC
    {
        private ISprite sprite;
        private Vector2 location;
        private Color color;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public float DamageAmount => throw new NotImplementedException();

        public Fire()
        {
            sprite = NPCSpriteFactory.Instance.CreateNPCFire();
            location = Constant.EnemyStartPosition;
            color = Color.White;
        }

        public void TakeDamage(int DamageAmount)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(float damageAmount)
        {
            throw new NotImplementedException();
        }
    }
}
