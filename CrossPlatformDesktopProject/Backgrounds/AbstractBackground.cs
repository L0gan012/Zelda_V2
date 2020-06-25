using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class AbstractBackground : IBackground
    {
        protected ISprite Sprite { get; set; }
        protected Vector2 Position { get; set; }
        protected Color Color { get; set; }

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
