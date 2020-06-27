namespace Sprint2
{
    public static class LinkItemCollisionHandler
    {
        public static void HandleCollision(ILink link, IItem item, ICollision collision)
        {
            item.PickUp();
        }
    }
}
