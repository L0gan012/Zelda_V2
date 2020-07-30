using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{ 
    public abstract class AbstractOption : IOption
    {
        public Vector2 Position { get; protected set; }

        protected Color Color { get; set; }

        public AbstractOption()
        {
        }

        protected void addToPageStack()
        {
            if (Game1.Instance.State is StateSettings)
            {
                ((StateSettings)Game1.Instance.State).PreviousPages.Push(((StateSettings)Game1.Instance.State).SettingsPage);
            }
        }

        public abstract void Select();

        public virtual void Update()
        {

        }

        public abstract void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont);
    }
}
