using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IBlock
    {
        void Draw(SpriteBatch spriteBatch, Vector2 location);

        void Update();
        Rectangle getDestinationRectangle();
    }
}
