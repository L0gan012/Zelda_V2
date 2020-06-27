namespace Sprint2
{
    public class LinkItemCollisionHandler
    {
        public void HandleCollision(ILink link, IItem item, ICollision collision)
        {
            item.PickUp(link);
        }
    }
}
