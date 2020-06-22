using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2.Sprite
{
    public class SpriteProjectileWoodenBoomerang : AbstractAnimatedSprite
    {
        public SpriteProjectileWoodenBoomerang(Texture2D texture)
        {
            this.Texture = texture;
            Rows = 1;
            Columns = 8;
            CurrentFrame = 0;
            CurrentTick = 0;
            TotalFrames = Rows * Columns;
            TicksPerFrame = 2;
        }
    }
}
