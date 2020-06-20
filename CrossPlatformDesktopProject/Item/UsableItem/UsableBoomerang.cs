using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBoomerang : AbstractItem, IUsableItem
    {
        private Vector2 startPosition;

        private Rectangle boomerangPerimeter;
        private int deltaX;
        private int deltaY;

        public UsableBoomerang(ILink link)
        {
            startPosition = link.Position;
            boomerangPerimeter = new Rectangle((int)link.Position.X - Constant.BoomerangDistance, (int)link.Position.Y - Constant.BoomerangDistance, Constant.BoomerangDistance*2, Constant.BoomerangDistance*2);
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenBoomerang();
            Color = Color.White;
        }

        public override void Update()
        {
            if(boomerangPerimeter.Contains(Location.X, Location.Y))
            {
                Location = new Vector2(Location.X + deltaX * Constant.BoomerangSpeed, Location.Y + deltaY * Constant.BoomerangSpeed);
            }

            Sprite.Update();
        }

        public void UseDown()
        {
            Location = new Vector2(startPosition.X, startPosition.Y + Constant.ItemOffset);
            deltaX = 0;
            deltaY = 1;
        }

        public void UseLeft()
        {
            Location = new Vector2(startPosition.X - Constant.ItemOffset, startPosition.Y);
            deltaX = -1;
            deltaY = 0;
        }

        public void UseRight()
        {
            Location = new Vector2(startPosition.X + Constant.ItemOffset, startPosition.Y);
            deltaX = 1;
            deltaY = 0;
        }

        public void UseUp()
        {
            Location = new Vector2(startPosition.X, startPosition.Y - Constant.ItemOffset);
            deltaX = 0;
            deltaY = -1;
        }
    }
}
