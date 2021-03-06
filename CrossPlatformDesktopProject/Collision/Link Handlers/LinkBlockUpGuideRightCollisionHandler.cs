﻿using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkBlockUpGuideRightCollisionHandler
    {
        public static void HandleCollision(ILink link, IBlock block, Enumerations.CollisionSide collision)
        {
            Contract.Requires(link != null);
            Contract.Requires(block != null);

            link.Position += new Vector2(1 * Constant.DisplayScaleX, 0);
        }
    }
}
