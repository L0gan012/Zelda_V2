using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkBlockUpSealStopCollisionHandler
    {
        public static void HandleCollision(ILink link, IBlock block, Enumerations.CollisionSide collision)
        {
            Contract.Requires(link != null);
            Contract.Requires(block != null);

        }
    }
}
