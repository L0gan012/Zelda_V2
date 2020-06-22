using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteItemWoodenSword : AbstractSprite
    {
        public SpriteItemWoodenSword(Texture2D texture)
        {
            this.Texture = texture;
            Rows = 1;
            Columns = 1;
            CurrentFrame = 0;
        }
    }
}
