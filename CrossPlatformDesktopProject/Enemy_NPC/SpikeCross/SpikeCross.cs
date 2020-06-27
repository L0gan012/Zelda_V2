using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class SpikeCross : AbstractGameObject, INPC
    {
        private bool forward;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public SpikeCross()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemySpikeCross();
            Position = Constant.EnemyStartPosition;
            Color = Color.White;
            forward = true;
        }

        public void TakeDamage(int DamageAmount)
        {
            throw new NotImplementedException();
        }

    }
}
