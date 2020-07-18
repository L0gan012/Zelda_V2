using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    class SpriteHUDInventory : AbstractSprite
    {
        public SpriteHUDInventory(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }
    }
}
