using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface ISpriteEffect
    {
     //   Vector2 Position { get; set; }
        Color Color { get; set; }
      //  ISprite Sprite { get; set; }
        Vector2 Velocity { get; set; }
        bool IsDestructable { get; set; }
        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
