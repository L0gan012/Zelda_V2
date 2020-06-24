using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteBackgroundTwo : AbstractSprite
    {
        public SpriteBackgroundTwo(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }
    }
}
