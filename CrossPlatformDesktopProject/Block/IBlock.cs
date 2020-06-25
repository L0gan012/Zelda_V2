using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IBlock : IGameObject
    {
        void Draw(SpriteBatch spriteBatch, Vector2 location);

        void Update();
    }
}
