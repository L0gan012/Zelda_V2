using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class Zol : AbstractGameObject, INPC
    {
        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Zol()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyZol();
            Position = Constant.EnemyStartPosition;
            Color = Color.White;
        }

        public void TakeDamage()
        {
        }

    }
}
