using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ISprite
    {
        int TotalFrames { get; set; }

        int TicksPerFrame { get; set; }

        void Update();
        
        void Draw(SpriteBatch spriteBatch, Color color, Vector2 position);

        float GetHeight();

        float GetWidth();
    }
}
