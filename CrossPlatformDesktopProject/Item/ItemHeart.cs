namespace Sprint2
{
    public class ItemHeart : AbstractItem
    {
        public ItemHeart()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteHeart();
            Position = Constant.ItemStartPosition;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.HP++;
        }
    }
}