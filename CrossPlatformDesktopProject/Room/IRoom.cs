using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface IRoom 
    {

        void StoreRoom();
        void LoadRoom();

        void Draw(SpriteBatch spriteBatch);

        void Update();

    }
}
