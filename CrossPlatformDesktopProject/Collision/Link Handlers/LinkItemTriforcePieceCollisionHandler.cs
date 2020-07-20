using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkItemTriforcePieceCollisionHandler
    {
        public static void HandleCollision(ILink link, IItem item, Enumerations.CollisionSide collisionSide)
        {
            Contract.Requires(link != null);
            Contract.Requires(item != null);

            item.PickUp(link);
            SoundManager.Instance.PlayPickUpTriforcePieceMusic();
            link.State = new LinkGetItemState(link);
            Game1.Instance.State = new StateWinning(Game1.Instance.State);
        }
    }
}
