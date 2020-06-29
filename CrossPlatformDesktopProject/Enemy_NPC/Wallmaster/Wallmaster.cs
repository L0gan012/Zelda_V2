using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Wallmaster : AbstractNPC
    {

        private bool left;
        private float limit;
        private int deltaX;
        private float prevX;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyGround;
            set => _ = Enumerations.GameObjectType.EnemyGround;
        }



        public Wallmaster()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyWallmasterLeft();
            Position = Constant.EnemyStartPosition;
            Color = Color.White;
        }

        public override void Update()
        {

            Sprite.Update();

        }
    }
}
