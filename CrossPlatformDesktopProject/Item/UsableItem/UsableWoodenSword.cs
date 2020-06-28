using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class UsableWoodenSword : AbstractUsable
    {
        public static UsableWoodProjectileSword projectile { get; set; }
        public static bool IsMoving { get; set; }

        public UsableWoodenSword(IGameObject user)
        {
            User = user;
            //Link health status check later
            if(projectile == null)
            {
                projectile = new UsableWoodProjectileSword(user);
                IsMoving = false;
            }
        }

        public override void Update()
        {
            if (projectile != null)
            {
                projectile.Update();
            }
            base.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (projectile != null)
            {
                projectile.Draw(spriteBatch);
            }
            base.Draw(spriteBatch);
        }

        public override void UseLeft()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteWoodenSwordLeft();
            if (!IsMoving)
            {
                projectile.UseLeft();
            }
            base.UseLeft();
        }

        public override void UseRight()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteWoodenSwordRight();
            if (!IsMoving)
            {
                projectile.UseRight();
            }
            base.UseRight();
        }

        public override void UseUp()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteWoodenSwordUp();
            if (!IsMoving)
            {
                projectile.UseUp();
            }
            base.UseUp();
        }

        public override void UseDown()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteWoodenSwordDown();
            if (!IsMoving)
            {
                projectile.UseDown();
            }
            base.UseDown();
        }
    }
}
