using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteItemTriforcePiece : AbstractAnimatedSprite
    {
        public SpriteItemTriforcePiece(Texture2D texture)
        {
            this.Texture = texture;
            Rows = 1;
            Columns = 2;
            CurrentFrame = 0;
            CurrentTick = 0;
            TotalFrames = Rows * Columns;
        }
    }
}
