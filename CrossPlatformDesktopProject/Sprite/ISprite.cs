using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ISprite
    {
        void Update();
        
        void Draw(SpriteBatch spriteBatch, Color color, Vector2 position);

        int GetHeight();

        int GetWidth();
    }
}
