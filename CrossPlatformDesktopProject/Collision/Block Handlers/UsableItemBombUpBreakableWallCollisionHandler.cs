﻿using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class UsableItemBombUpBreakableWallCollisionHandler
    {
        public static void HandleCollision(IUsableItem item, IBlock block, Enumerations.CollisionSide collision)
        {
            Contract.Requires(block != null);
            Contract.Requires(item != null);
            block.IsDestructable = true;
            foreach (IDoorTrigger doorTrigger in Room.CurrentRoomDoorTriggers)
            {
                if(doorTrigger.GameObjectType == Enumerations.GameObjectType.DoorTriggerUp)
                {
                    doorTrigger.IsDestructable = true;
                }
            }

            IBlock newDoor = new BlockUpBombedOpening();
            newDoor.Position = block.Position;
            IDoorTrigger newTrigger = new BlockUpOverBombed();
            newTrigger.Position = Constant.UpOverBombedPosition;
            Room.CurrentRoomBlocks.Add(newDoor);
            Room.CurrentRoomDoorTriggers.Add(newTrigger);
            SoundManager.Instance.PlayFoundSecret();



        }
    }
}
