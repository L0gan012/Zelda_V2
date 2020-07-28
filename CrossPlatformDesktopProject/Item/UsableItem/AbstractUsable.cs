using Microsoft.Xna.Framework;

namespace Sprint2
{
    public abstract class AbstractUsable : AbstractItem, IUsableItem
    {
        protected IGameObject User { get; set; }

        public float DamageAmount { get; protected set; }
        public Vector2 InventoryPosition { get; set; }

        public virtual void UseLeft()
        {
            IsDestructable = false;
            Position = new Vector2(User.Center.X - ItemConstants.ItemOffset - Sprite.GetWidth() / 2, User.Center.Y - Sprite.GetHeight() / 2);
            Room.CurrentRoomUsableItems.Add(this);
        }

        public virtual void UseRight()
        {
            IsDestructable = false;
            Position = new Vector2(User.Center.X + ItemConstants.ItemOffset - Sprite.GetWidth() / 2, User.Center.Y - Sprite.GetHeight() / 2);
            Room.CurrentRoomUsableItems.Add(this);
        }

        public virtual void UseUp()
        {
            IsDestructable = false;
            Position = new Vector2(User.Center.X - Sprite.GetWidth() / 2, User.Center.Y - ItemConstants.ItemOffset - Sprite.GetHeight() / 2);
            Room.CurrentRoomUsableItems.Add(this);
        }

        public virtual void UseDown()
        {
            IsDestructable = false;
            Position = new Vector2(User.Center.X - Sprite.GetWidth() / 2, User.Center.Y + ItemConstants.ItemOffset - Sprite.GetHeight() / 2);
            Room.CurrentRoomUsableItems.Add(this);
        }

        public override void PickUp(IPlayer user)
        {
            //do nothing
        }
    }
}
