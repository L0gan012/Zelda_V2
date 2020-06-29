using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Sprite
{
    class SpriteDebugBlankTexture : AbstractSprite
    
    {
        public SpriteDebugBlankTexture(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }
    }
}
