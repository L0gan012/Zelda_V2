using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkBlockStairsTriggerCollisionHandler
    {


        private static StateRoomTransition roomTransition = new StateRoomTransition(Game1.Instance.State);
        public static void HandleCollision(ILink link, IBlock block, Enumerations.CollisionSide collision)

        {
            Contract.Requires(link != null);
            Contract.Requires(doorTrigger != null);

            roomTransition.Update(doorTrigger);

        }
    }
}
