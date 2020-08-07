using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class UsableItemBombLeftBreakableWallCollisionHandler
    {
        public static void HandleCollision(IUsableItem item, IBlock block, Enumerations.CollisionSide collision)
        {
            Contract.Requires(block != null);
            Contract.Requires(item != null);
            block.IsDestructable = true;
            foreach (IDoorTrigger doorTrigger in Room.CurrentRoomDoorTriggers)
            {
                if (doorTrigger.GameObjectType == Enumerations.GameObjectType.DoorTriggerLeft)
                {
                    doorTrigger.IsDestructable = true;
                }
            }

            IBlock newDoor = new BlockLeftBombedOpening();
            newDoor.Position = block.Position;
            IDoorTrigger newTrigger = new BlockLeftOverBombed();
            newTrigger.Position = new Vector2(Constant.LeftOverBombedPositionNative.X * Game1.Instance.graphics.PreferredBackBufferWidth / Constant.OriginalNesWidth, (Constant.LeftOverBombedPositionNative.Y + HUDConstants.HUDHeight) * Game1.Instance.graphics.PreferredBackBufferHeight / Constant.OriginalNesHeight);
            Room.CurrentRoomBlocks.Add(newDoor);
            Room.CurrentRoomDoorTriggers.Add(newTrigger);
            SoundManager.Instance.PlayFoundSecret();

            int oppositeRoom = GameObjects.Instance.LevelListPosition - 1;
            Enumerations.Direction doorDirection = Enumerations.Direction.Right;
            Enumerations.DoorType doorType = Enumerations.DoorType.Bombed;
            ToolsXML toolsXml = new ToolsXML();
            toolsXml.ReplaceOppositeDoorNodeXML(oppositeRoom, doorType, doorDirection);


        }
    }
}
