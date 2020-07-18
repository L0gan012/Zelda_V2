using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class UsableItemWallCollisionHandler
    {
        public static void HandleCollision(IUsableItem item, IBlock block, Enumerations.CollisionSide collision)
        {
            Contract.Requires(block != null);
            Contract.Requires(item != null);
            item.IsDestructable = true;
            UsableWoodenSword.projectile = null;
            UsableWoodenSword.IsMoving = false;
            Room.CurrentRoomSpriteEffects.Add(new EffectSwordBeamCollision(item.Position));

        }
    }
}
