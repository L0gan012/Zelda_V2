using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteBackgroundOne : AbstractAnimatedSprite
    {
        public SpriteBackgroundOne(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            CurrentTick = 0;
            TotalFrames = Rows * Columns;
            TicksPerFrame = 8;
        }
    }
}
