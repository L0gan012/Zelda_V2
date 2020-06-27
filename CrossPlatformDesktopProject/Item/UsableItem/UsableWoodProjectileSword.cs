using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableWoodProjectileSword : AbstractUsableMoving
    {
        private Rectangle range;

        public UsableWoodProjectileSword(ILink link)
        {
            Link = link;
            range = new Rectangle(0, 0, Constant.ScreenWidth, Constant.ScreenHeight);
        }

        public override void Update()
        {
            Position = new Vector2(Position.X + DeltaX * Constant.ArrowSpeed, Position.Y + DeltaY * Constant.ArrowSpeed);

            if (!range.Contains(Center))
            {
                UsableWoodenSword.projectile = null;
                UsableWoodenSword.IsMoving = false;
            }

            base.Update();
        }

        public override void UseLeft()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenSwordLeft();
            UsableWoodenSword.IsMoving = true;
            base.UseLeft();
        }

        public override void UseRight()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenSwordRight();
            UsableWoodenSword.IsMoving = true;
            base.UseRight();
        }

        public override void UseUp()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenSwordUp();
            UsableWoodenSword.IsMoving = true;
            base.UseUp();
        }

        public override void UseDown()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenSwordDown();
            UsableWoodenSword.IsMoving = true;
            base.UseDown();
        }
    }
}
