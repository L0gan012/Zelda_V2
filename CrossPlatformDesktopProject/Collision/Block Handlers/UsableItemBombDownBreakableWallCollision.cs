using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class UsableItemBombDownBreakableWallCollisionHandler
    {
        public static void HandleCollision(IUsableItem item, IBlock block, Enumerations.CollisionSide collision)
        {
            Contract.Requires(block != null);
            Contract.Requires(item != null);
            block.IsDestructable = true;
            foreach (IDoorTrigger doorTrigger in Room.CurrentRoomDoorTriggers)
            {
                if (doorTrigger.GameObjectType == Enumerations.GameObjectType.DoorTriggerDown)
                {
                    doorTrigger.IsDestructable = true;
                }
            }

            IBlock newDoor = new BlockDownBombedDoor();
            newDoor.Position = block.Position;
            IDoorTrigger newTrigger = new BlockDownOverBombed();
            newTrigger.Position = new Vector2(Constant.DownOverBombedPositionNative.X * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (Constant.DownOverBombedPositionNative.Y + HUDConstants.HUDHeight) * Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight);
            Room.CurrentRoomBlocks.Add(newDoor);
            Room.CurrentRoomDoorTriggers.Add(newTrigger);
            SoundManager.Instance.PlayFoundSecret();

            int oppositeRoom = GameObjects.Instance.LevelListPosition + Constant.DungeonGridWidth;
            Enumerations.Direction doorDirection = Enumerations.Direction.Up;
            Enumerations.DoorType doorType = Enumerations.DoorType.Bombed;
            ToolsXML toolsXml = new ToolsXML();
            toolsXml.ReplaceOppositeDoorNodeXML(oppositeRoom, doorType, doorDirection);
        }
    }
}
