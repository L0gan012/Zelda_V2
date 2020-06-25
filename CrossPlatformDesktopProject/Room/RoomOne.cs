using Sprint2.Room;
using System.Linq;
using System.Collections.Generic;

namespace Sprint2
{
    public class RoomOne : AbstractRoom
    {
  
        public RoomOne()
        {
            RoomNumber = 1;
            CurrentRoomItems = new List<IItem>();
            CurrentRoomChars = new List<INPC>();
            CurrentRoomBlocks = new List<IBlock>();
        }

    }
}
