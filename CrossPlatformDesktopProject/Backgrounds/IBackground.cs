using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface IBackground
    {
        Vector2 Position { get; set; }

        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
