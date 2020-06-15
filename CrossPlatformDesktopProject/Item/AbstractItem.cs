using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public abstract class AbstractItem : IItem
    {
        protected ISprite Sprite { get; set; }
        protected Vector2 Location { get; set; }
        protected Color Color { get; set; }

        public void Draw(SpriteBatch spriteBatch)
        {
            Sprite.Draw(spriteBatch, Color, Location);
        }


        public void Update()
        {
            //if(Sprite != null)
            //{
                Sprite.Update();
            //}

        }

    }
}
