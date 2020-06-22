using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class ProjectileWoodenSwordDown : IProjectile
    {
        private ISprite projectileSprite;
        private Vector2 projectilePosition;
        private Rectangle projectileHitBox;
        private Color color;

        public ProjectileWoodenSwordDown(Vector2 projectileSourcePosition)
        {
            Vector2 weaponOffset = new Vector2(3, 16);
            projectileSprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenSwordUp();
            projectilePosition = new Vector2(projectileSourcePosition.X + weaponOffset.X, projectileSourcePosition.Y + weaponOffset.Y);
            projectileHitBox = new Rectangle((int)projectilePosition.X, (int)projectilePosition.Y, Constant.VerticalSwordWidth, Constant.VerticalSwordHeight);
            color = Color.White;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            projectileSprite.Draw(spriteBatch, color, position);
        }

        public void Update()
        {
            projectilePosition = new Vector2(projectilePosition.X, projectilePosition.Y + 1 * Constant.SwordBeamSpeed);
            projectileSprite.Update();
        }
    }
}