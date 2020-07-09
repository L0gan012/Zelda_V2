using System.Collections.Generic;

namespace Sprint2
{
    public class RoomFour : AbstractRoom
    {
        public RoomFour()
        {
            RoomNumber = 4;
            CurrentRoomItems = new List<IItem>();
            CurrentRoomChars = new List<INPC>();
            CurrentRoomBlocks = new List<IBlock>();
            CurrentRoomPlayers = new List<IPlayer>();
            CurrentRoomProjectiles = new List<IProjectile>();
            CurrentRoomUsableItems = new List<IUsableItem>();
        }
    }
}
