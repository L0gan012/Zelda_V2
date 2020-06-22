using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteItemHeartContainer : AbstractAnimatedSprite
    {
        public SpriteItemHeartContainer(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 1;
            CurrentFrame = 0;
        }
    }
}
