using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Sprint2
{
    public interface IMap
    {
        Vector2 PlayerGridLocation { get; set; }

        List<IRoom> DiscoveredRooms { get; set; }
    }
}
