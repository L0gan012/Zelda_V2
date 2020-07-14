using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Sprint2
{
    public class Map : IMap
    {
        private IPlayer user;

        public Vector2 PlayerGridLocation { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public List<IRoom> DiscoveredRooms { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Map(IPlayer user)
        {
            this.user = user;
        }
    }
}
