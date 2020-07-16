using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public interface IRoom 
    {
        List<Enumerations.Direction> doorDirections { get; set; }

        void StoreRoom(int room);

        void LoadRoom();

        void Draw(SpriteBatch spriteBatch);

        void Update();
    }
}
