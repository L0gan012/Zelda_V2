using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkDoorTriggerDownCollisionHandler
    {
        private static StateRoomTransition roomTransition = new StateRoomTransition(Game1.Instance.state);

        public static void HandleCollision(ILink link, IBlock block, Enumerations.CollisionSide collision)
        {
            Contract.Requires(link != null);
            Contract.Requires(block != null);
            roomTransition.Update(block);

            
        }
    }
}
