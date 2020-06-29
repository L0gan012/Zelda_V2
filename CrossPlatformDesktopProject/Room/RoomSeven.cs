using Sprint2.Room;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework;
using Sprint2.Collision;

namespace Sprint2
{
    public class RoomSeven : AbstractRoom
    {
        ILink link;
        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> narrowBandCollisionEventList;
        List<Tuple<IGameObject, IGameObject, Enumerations.CollisionSide, Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>>> collisionEventList;
        CollisionHandler collisionHandler;
       // CollisionHandler collisionHandlerVertical;
        public RoomSeven(Game1 game)
        {
            RoomNumber = 7;


            if(game.Link != null)
            {
                this.link = game.Link;
            }
            
            CurrentRoomItems = new List<IItem>();
            CurrentRoomChars = new List<INPC>();
            CurrentRoomBlocks = new List<IBlock>();
            CurrentRoomPlayers = new List<IPlayer>();
            CurrentRoomProjectiles = new List<IProjectile>();
            CurrentRoomUsableItems = new List<IUsableItem>();

            
            CurrentRoomPlayers.Add(link);

            

         

            

            CollisionDetector collisionDetectorRoom7 = new CollisionDetector(CurrentRoomPlayers, CurrentRoomChars, CurrentRoomProjectiles, CurrentRoomBlocks, CurrentRoomItems, CurrentRoomUsableItems);

            narrowBandCollisionEventList = collisionDetectorRoom7.NarrowBandCollisionDetect();
                
            collisionHandler = new CollisionHandler(narrowBandCollisionEventList);

            collisionHandler.CorrectHorizontal();

            collisionHandler.CorrectVertical();

            collisionHandler.HandleAllEvents();

            


            







        }


        

    }
}
