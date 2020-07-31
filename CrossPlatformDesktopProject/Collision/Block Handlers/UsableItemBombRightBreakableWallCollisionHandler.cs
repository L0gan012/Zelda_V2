﻿using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class UsableItemBombRightBreakableWallCollisionHandler
    {
        public static void HandleCollision(IUsableItem item, IBlock block, Enumerations.CollisionSide collision)
        {
            Contract.Requires(block != null);
            Contract.Requires(item != null);
            block.IsDestructable = true;
            foreach (IDoorTrigger doorTrigger in Room.CurrentRoomDoorTriggers)
            {
                if (doorTrigger.GameObjectType == Enumerations.GameObjectType.DoorTriggerRight)
                {
                    doorTrigger.IsDestructable = true;
                }
            }

            IBlock newDoor = new BlockRightBombedOpening();
            newDoor.Position = block.Position;
            IDoorTrigger newTrigger = new BlockRightOverBombed();
            newTrigger.Position = Constant.RightOverBombedPosition;
            Room.CurrentRoomBlocks.Add(newDoor);
            Room.CurrentRoomDoorTriggers.Add(newTrigger);
            SoundManager.Instance.PlayFoundSecret();

            int oppositeRoom = GameObjects.Instance.LevelListPosition + 1;
            Enumerations.Direction doorDirection = Enumerations.Direction.Left;
            Enumerations.DoorType doorType = Enumerations.DoorType.Bombed;
            ToolsXML toolsXml = new ToolsXML();
            toolsXml.ReplaceOppositeDoorNodeXML(oppositeRoom, doorType, doorDirection);


        }
    }
}
