using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Goriya : AbstractNPC
    {

        private bool left;
        private float limit;
        private int deltaX;
        private float prevX;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }



        public Goriya()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGoriyaWalkDown();
            Position = Constant.EnemyStartPosition;
            Color = Color.White;
        }

        public override void Update()
        {

            Sprite.Update();

        }
    }
}
