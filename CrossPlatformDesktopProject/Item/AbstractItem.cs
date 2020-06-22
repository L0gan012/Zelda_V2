using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public abstract class AbstractItem : IItem
    {
        protected ISprite Sprite { get; set; }
        protected Vector2 Location { get; set; }
        protected Color Color { get; set; }

        protected Vector2 Center
        {
            get
            {
                float x = Location.X + Sprite.GetWidth() / 2.0f;
                float y = Location.Y + Sprite.GetHeight() / 2.0f;

                return new Vector2(x, y);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if(Sprite != null)
            {
                Sprite.Draw(spriteBatch, Color, Location);
            }
        }

        public virtual void Update()
        {
            Sprite.Update();
        }
    }
}
