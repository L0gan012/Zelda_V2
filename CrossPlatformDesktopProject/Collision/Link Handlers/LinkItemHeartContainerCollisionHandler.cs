using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkItemHeartContainerCollisionHandler
    {
        public static void HandleCollision(ILink link, IItem item, Enumerations.CollisionSide collisionSide)
        {
            Contract.Requires(link != null);
            Contract.Requires(item != null);

            item.PickUp(link);
            /*

            //Add One heart to Link's Max Life

            //play the following for the length of time it takes to fill one heart (2 half hearts)
            int currentTick = 0;
            while (currentTick < (2 * Constant.TicksPerFrameHalfHeart))
            {
                SoundManager.Instance.PlayFillHeartMeterLooped();
                currentTick++;
            }
            */


        }
    }
}
