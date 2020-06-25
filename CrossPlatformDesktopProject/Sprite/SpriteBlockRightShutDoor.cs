using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Sprite
{
    class SpriteBlockRightShutDoor : AbstractSprite
    {
        public SpriteBlockRightShutDoor(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }
    }
}
