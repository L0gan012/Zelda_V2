using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Item
{
    public abstract class AbstractItem : IItem
    {
        protected ISprite sprite { get; set; }
        protected Vector2 location { get; set; }
        protected Color color { get; set; }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, color, location);
        }


        public void Update()
        {
            sprite.Update();
        }

    }
}
