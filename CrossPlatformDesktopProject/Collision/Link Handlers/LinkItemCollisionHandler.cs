using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkItemCollisionHandler
    {
        public static void HandleCollision(ILink link, IItem item, ICollision collision)
        {
            Contract.Requires(link != null);
            Contract.Requires(item != null);

            item.PickUp(link);
        }
    }
}
