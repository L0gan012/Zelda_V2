using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemHeartContainer : AbstractItem
    {
        public ItemHeartContainer()
        {
           Sprite = ItemsSpriteFactory.Instance.CreateSpriteHeartContainer();
           Position = Constant.ItemStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.ItemHeartContainer;
            set => _ = Enumerations.GameObjectType.ItemHeartContainer;
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.MaxHP++;
            user.HP++;
        }


    }
}
