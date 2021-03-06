﻿using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkBlockLeftLockStopCollisionHandler
    {
        public static void HandleCollision(ILink link, IBlock block, Enumerations.CollisionSide collision)
        {
            Contract.Requires(link != null);
            Contract.Requires(block != null);

            if (InventoryAgrees(link))
            {
                block.IsDestructable = true;
                foreach (IDoorTrigger doorTrigger in Room.CurrentRoomDoorTriggers)
                {
                    if (doorTrigger.GameObjectType == Enumerations.GameObjectType.DoorTriggerLeft)
                    {
                        doorTrigger.IsDestructable = true;
                    }
                }

                foreach (IBlock blockDoor in Room.CurrentRoomBlocks)
                {
                    if (block.GameObjectType == Enumerations.GameObjectType.DoorLeft)
                    {
                        blockDoor.IsDestructable = true;
                    }
                }

                IBlock newDoor = new BlockLeftOpenDoor();
                newDoor.Position = new Vector2(Constant.LeftDoorPositionNative.X * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (Constant.LeftDoorPositionNative.Y + HUDConstants.HUDHeight) * Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight);
                IDoorTrigger newTrigger = new BlockLeftOverDoor();
                newTrigger.Position = new Vector2(Constant.LeftOverDoorPositionNative.X * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (Constant.LeftOverDoorPositionNative.Y + HUDConstants.HUDHeight) * Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight);
                Room.CurrentRoomBlocks.Add(newDoor);
                Room.CurrentRoomDoorTriggers.Add(newTrigger);
                SoundManager.Instance.PlayDoorStateChange();

                int oppositeRoom = GameObjects.Instance.LevelListPosition - 1;
                Enumerations.Direction doorDirection = Enumerations.Direction.Right;
                Enumerations.DoorType doorType = Enumerations.DoorType.Locked;
                ToolsXML toolsXml = new ToolsXML();
                toolsXml.ReplaceOppositeDoorNodeXML(oppositeRoom, doorType, doorDirection);
            }

        }

        private static bool InventoryAgrees(ILink link)
        {
            bool canUseKey = link.Inventory.KeyCount > 0;
            if (canUseKey)
            {
                link.Inventory.KeyCount--;
            }

            return canUseKey;
        }
    }
}
