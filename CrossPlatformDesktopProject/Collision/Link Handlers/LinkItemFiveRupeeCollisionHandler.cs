﻿using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkItemFiveRupeeCollisionHandler
    {
        public static void HandleCollision(ILink link, IItem item, Enumerations.CollisionSide collisionSide)
        {
            Contract.Requires(link != null);
            Contract.Requires(item != null);

            item.PickUp(link);
            SoundManager.Instance.PlayRupeePickUp();
        }
    }
}