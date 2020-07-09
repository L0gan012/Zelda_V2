using System.Collections.Generic;

namespace Sprint2
{
    public class RoomThirteen : AbstractRoom
    {
        public RoomThirteen()
        {
            RoomNumber = 13;
            CurrentRoomItems = new List<IItem>();
            CurrentRoomChars = new List<INPC>();
            CurrentRoomBlocks = new List<IBlock>();
            CurrentRoomPlayers = new List<IPlayer>();
            CurrentRoomProjectiles = new List<IProjectile>();
            CurrentRoomUsableItems = new List<IUsableItem>();
        }
    }
}
