using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2.Factory;

namespace Sprint2.Sprite
{
    public class SpriteEnemyDodongoDownPuffed : AbstractSprite
    {
        public SpriteEnemyDodongoDownPuffed(Texture2D texture)
        {
            this.Texture = texture;
            Rows = 1;
            Columns = 1;
            CurrentFrame = 0;
        }
    }
}
