using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBow : AbstractUsableMoving
    {
        private Rectangle range;
        private bool woodenArrows;

        public UsableBow(ILink link, bool woodenArrows)
        {
            Link = link;
            Color = Color.White;
            range = new Rectangle(0, 0, Constant.ScreenWidth, Constant.ScreenHeight);
            this.woodenArrows = woodenArrows;
        }

        public override void UseLeft()
        {
            if (woodenArrows)
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowLeft();
            }
            else
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowLeft();
            }
            base.UseLeft();
        }

        public override void UseRight()
        {
            if (woodenArrows)
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowRight();
            }
            else
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowRight();
            }
            base.UseRight();
        }

        public override void UseUp()
        {
            if (woodenArrows)
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowUp();
            }
            else
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowUp();
            }
            base.UseUp();
        }

        public override void UseDown()
        {
            if (woodenArrows)
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowDown();
            }
            else
            {
                Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowDown();
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
