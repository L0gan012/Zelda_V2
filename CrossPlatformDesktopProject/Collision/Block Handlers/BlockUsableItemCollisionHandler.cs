using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class BlockUsableItemCollisionHandler
    {
        public static void HandleCollision(IUsableItem item, IBlock block, Enumerations.CollisionSide collision)
        {
            Contract.Requires(block != null);
            Contract.Requires(item != null);
            item.IsDestructable = true;
        }
    }
}
