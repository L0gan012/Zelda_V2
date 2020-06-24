using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableWoodenSword : AbstractUsableMoving
    {
        public UsableWoodenSword(ILink link)
        {
            Link = link;
            Color = Color.White;
        }

        public override void Update()
        {

            base.Update();
        }

        public override void UseLeft()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteWoodenSwordLeft();
            base.UseLeft();
        }

        public override void UseRight()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteWoodenSwordRight();
            base.UseRight();
        }

        public override void UseUp()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteWoodenSwordUp();
            base.UseUp();
        }

        public override void UseDown()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteWoodenSwordDown();
            base.UseDown();
        }
    }
}
