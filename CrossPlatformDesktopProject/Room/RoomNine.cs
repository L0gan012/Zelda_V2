using Sprint2.Room;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework;
using Sprint2.Collision;

namespace Sprint2
{
    public class RoomNine : AbstractRoom
    {
        CollisionDetector collisionDetector;
        CollisionHandler collisionHandler;

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
