using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteProjectileWoodenArrowUp : AbstractSprite
    {
        public SpriteProjectileWoodenArrowUp(Texture2D texture)
        {
            this.Texture = texture;
            Rows = 1;
            Columns = 1;
            CurrentFrame = 0;
        }
    }
}
