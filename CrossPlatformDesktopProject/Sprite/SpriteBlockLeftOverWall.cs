using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteBlockLeftOverWall : AbstractSprite
    {

        public SpriteBlockLeftOverWall(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }

    }
}
