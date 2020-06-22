using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteItemClock : AbstractSprite
    {
        public SpriteItemClock(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 1;
            CurrentFrame = 0;
        }
    }
}
