using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public interface IMap
    {
        Vector2 PlayerGridLocation { get; set; }

        List<IRoom> DiscoveredRooms { get; }

        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
