using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteProjectileSilverArrowRight : AbstractSprite
    {
        public SpriteProjectileSilverArrowRight(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 1;
            CurrentFrame = 0;
        }
    }
}
