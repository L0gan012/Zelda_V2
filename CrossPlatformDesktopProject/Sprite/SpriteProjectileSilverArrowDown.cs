using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteProjectileSilverArrowDown : AbstractSprite
    {
        public SpriteProjectileSilverArrowDown(Texture2D texture)
        {
            this.Texture = texture;
            Rows = 1;
            Columns = 1;
            CurrentFrame = 0;
        }
    }
}
