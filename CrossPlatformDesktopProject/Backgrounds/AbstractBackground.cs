using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Backgrounds;


namespace Sprint2
{
    public class AbstractBackground : IBackground
    {
        protected ISprite Sprite { get; set; }
        protected Rectangle Location { get; set; }
        protected Color Color { get; set; }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Color, Location);
        }

        public void Update()
        {

        }
    }
}
