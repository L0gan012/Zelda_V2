using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBow : AbstractUsableMoving
    {
        private Rectangle range;
        private Enumerations.ArrowType type;

        public UsableBow(ILink link, Enumerations.ArrowType type)
        {
            Link = link;
            Color = Color.White;
            range = new Rectangle(0, 0, Constant.ScreenWidth, Constant.ScreenHeight);
            this.type = type;
        }

        public override void Update()
        {
            Position = new Vector2(Position.X + DeltaX * Constant.ArrowSpeed, Position.Y + DeltaY * Constant.ArrowSpeed);

            if (!range.Contains(Center))
            {
                Link.SecondaryItem = null;
            }

            base.Update();
        }

        public override void UseLeft()
        {
            switch (type)
            {
                case Enumerations.ArrowType.wooden:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowLeft();
                    break;
                case Enumerations.ArrowType.silver:
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
                case Enumerations.ArrowType.wooden:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowRight();
                    break;
                case Enumerations.ArrowType.silver:
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
                case Enumerations.ArrowType.wooden:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowUp();
                    break;
                case Enumerations.ArrowType.silver:
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
                case Enumerations.ArrowType.wooden:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowDown();
                    break;
                case Enumerations.ArrowType.silver:
                    Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowDown();
                    break;
                default:
                    break;
            }
            base.UseDown();
        }
    }
}
