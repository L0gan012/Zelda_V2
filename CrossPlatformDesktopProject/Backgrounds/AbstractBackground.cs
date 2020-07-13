using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class AbstractBackground : IBackground
    {
        public ISprite Sprite { get; set; }
        public Vector2 Position { get; set; }
        public Color Color { get; set; }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Color, Position);
        }

        public void Update()
        {
            Sprite.Update();
        }
    }
}
