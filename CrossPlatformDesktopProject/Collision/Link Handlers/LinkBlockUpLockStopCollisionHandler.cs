using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkBlockUpLockStopCollisionHandler
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
                    if (doorTrigger.GameObjectType == Enumerations.GameObjectType.DoorTriggerUp)
                    {
                        doorTrigger.IsDestructable = true;
                    }
                }

                foreach (IBlock blockDoor in Room.CurrentRoomBlocks)
                {
                    if (block.GameObjectType == Enumerations.GameObjectType.DoorUp)
                    {
                        blockDoor.IsDestructable = true;
                    }
                }

                IBlock newDoor = new BlockUpOpenDoor();
                newDoor.Position = new Vector2(Constant.UpDoorPositionNative.X * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (Constant.UpDoorPositionNative.Y + HUDConstants.HUDHeight) * Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight);
                IDoorTrigger newTrigger = new BlockUpOverDoor();
                newTrigger.Position = new Vector2(Constant.UpOverDoorPositionNative.X * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (Constant.UpOverDoorPositionNative.Y + HUDConstants.HUDHeight) * Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight);
                Room.CurrentRoomBlocks.Add(newDoor);
                Room.CurrentRoomDoorTriggers.Add(newTrigger);
                SoundManager.Instance.PlayDoorStateChange();

                int oppositeRoom = GameObjects.Instance.LevelListPosition - Constant.DungeonGridWidth;
                Enumerations.Direction doorDirection = Enumerations.Direction.Down;
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
