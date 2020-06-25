using Sprint2.Room;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class RoomTwo : AbstractRoom
    {


        public RoomTwo()
        {
            RoomNumber = 2;
            CurrentRoomItems = new List<IItem>();
            CurrentRoomChars = new List<INPC>();
            CurrentRoomBlocks = new List<IBlock>();
        }


        

    }
}
