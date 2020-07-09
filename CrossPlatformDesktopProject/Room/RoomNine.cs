using System.Collections.Generic;

namespace Sprint2
{
    public class RoomNine : AbstractRoom
    {
        public RoomNine()
        {
            RoomNumber = 9;
            CurrentRoomItems = new List<IItem>();
            CurrentRoomChars = new List<INPC>();
            CurrentRoomBlocks = new List<IBlock>();
            CurrentRoomPlayers = new List<IPlayer>();
            CurrentRoomProjectiles = new List<IProjectile>();
            CurrentRoomUsableItems = new List<IUsableItem>();
        }
    }
}
