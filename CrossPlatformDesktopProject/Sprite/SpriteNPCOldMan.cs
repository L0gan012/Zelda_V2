using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteNPCOldMan : AbstractSprite
    {
        public SpriteNPCOldMan(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }
    }
}