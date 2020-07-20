using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteBlock8x8Guide : AbstractSprite
    {
        public SpriteBlock8x8Guide(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }
    }
}
