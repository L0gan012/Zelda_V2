using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteBlock16x16Guide : AbstractSprite
    {
        public SpriteBlock16x16Guide(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }
    }
}
