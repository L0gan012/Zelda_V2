using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBow : AbstractUsableMoving
    {
        private Rectangle range;
        private ArrowType type;

        public enum ArrowType { wooden, silver}

        public UsableBow(ILink link, ArrowType type)
        {
            Link = link;
            Color = Color.White;
            range = new Rectangle(0, 0, Constant.ScreenWidth, Constant.ScreenHeight);
            this.type = type;
        }

        public override void UseLeft()
        {
            switch (type)
            {
                case ArrowType.wooden:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowLeft();
                    break;
                case ArrowType.silver:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowLeft();
                    break;
                default:
                    break;
            }
            base.UseLeft();
        }

        public override void UseRight()
        {
            switch (type)
            {
                case ArrowType.wooden:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowRight();
                    break;
                case ArrowType.silver:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowRight();
                    break;
                default:
                    break;
            }
            base.UseRight();
        }

        public override void UseUp()
        {
            switch (type)
            {
                case ArrowType.wooden:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowUp();
                    break;
                case ArrowType.silver:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowUp();
                    break;
                default:
                    break;
            }
            base.UseUp();
        }

        public override void UseDown()
        {
            switch (type)
            {
                case ArrowType.wooden:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowDown();
                    break;
                case ArrowType.silver:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowDown();
                    break;
                default:
                    break;
            }
            base.UseDown();
        }

        public override void Update()
        {
            Location = new Vector2(Location.X + DeltaX * Constant.ArrowSpeed, Location.Y + DeltaY * Constant.ArrowSpeed);

            if (!range.Contains(Center))
            {
                Link.Item = null;
            }
        }
    }
}
