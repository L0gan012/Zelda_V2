using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    class SpriteHUDDungeon : AbstractSprite
    {
        public SpriteHUDDungeon(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }
    }
}
