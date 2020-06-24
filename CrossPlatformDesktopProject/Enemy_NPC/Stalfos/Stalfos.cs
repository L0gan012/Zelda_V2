using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class Stalfos : AbstractGameObject, INPC
    {
        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Stalfos()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyStalfos();
            Position = Constant.EnemyStartPosition;
            Color = Color.White;
        }

        public void TakeDamage()
        {
        }

    }
}
