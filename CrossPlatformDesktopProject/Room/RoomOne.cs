using Sprint2.Room;
using System.Linq;
using System.Collections.Generic;
using Sprint2.Collision;

namespace Sprint2
{
    public class RoomOne : AbstractRoom
    {
        CollisionDetector collisionDetector;
        CollisionHandler collisionHandler;

        public RoomOne()
        {
            RoomNumber = 1;
            CurrentRoomItems = new List<IItem>();
            CurrentRoomChars = new List<INPC>();
            CurrentRoomBlocks = new List<IBlock>();
            CurrentRoomPlayers = new List<IPlayer>();
            CurrentRoomProjectiles = new List<IProjectile>();
            CurrentRoomUsableItems = new List<IUsableItem>();


            collisionDetector = new CollisionDetector(CurrentRoomPlayers, CurrentRoomChars, CurrentRoomProjectiles, CurrentRoomBlocks, CurrentRoomItems, CurrentRoomUsableItems);
            collisionHandler = new CollisionHandler();

        }

    }
}
