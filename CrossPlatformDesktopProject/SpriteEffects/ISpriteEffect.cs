using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ISpriteEffect
    {
        Color Color { get; set; }
        Vector2 Velocity { get; set; }
        bool IsDestructable { get; set; }
        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
