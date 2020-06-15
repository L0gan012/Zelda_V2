using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
   public interface IItem
    {
        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
