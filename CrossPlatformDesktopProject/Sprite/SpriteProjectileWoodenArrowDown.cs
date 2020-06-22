using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteProjectileWoodenArrowDown : AbstractSprite
    {
        public SpriteProjectileWoodenArrowDown(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 1;
            CurrentFrame = 0;
        }
    }
}
