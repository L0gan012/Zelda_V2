using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class Camera
    {
        public Matrix Transform { get; private set; }


        public void Follow(IPlayer targert)
        {
            var position = Matrix.CreateTranslation(-targert.Position.X, -targert.Position.Y, 0);
            var offset = Matrix.CreateTranslation(Constant.ScreenHeight, Constant.ScreenWidth, 0);
            Transform = position * offset;
        }

    }
}
