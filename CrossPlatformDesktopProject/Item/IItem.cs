using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
   public interface IItem
    {
        void Update();

        void Draw(SpriteBatch spriteBatch);

        //probably also a pick up method, deal with later

    }
}
