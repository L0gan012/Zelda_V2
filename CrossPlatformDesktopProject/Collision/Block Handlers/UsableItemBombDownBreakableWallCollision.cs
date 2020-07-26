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
            newTrigger.Position = Constant.DownOverBombedPosition;
            Room.CurrentRoomBlocks.Add(newDoor);
            Room.CurrentRoomDoorTriggers.Add(newTrigger);
            SoundManager.Instance.PlayFoundSecret();


        }
    }
}
