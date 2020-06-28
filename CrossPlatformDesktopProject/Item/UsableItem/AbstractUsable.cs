using Microsoft.Xna.Framework;

namespace Sprint2
{
    public abstract class AbstractUsable : AbstractItem, IUsableItem
    {
        protected IGameObject User { get; set; }
        public float DamageAmount { get; }

        public virtual void UseLeft()
        {
            Position = new Vector2(User.Center.X - Constant.ItemOffset - Sprite.GetWidth() / 2, User.Center.Y - Sprite.GetHeight() / 2);
        }

        public virtual void UseRight()
        {
            Position = new Vector2(User.Center.X + Constant.ItemOffset - Sprite.GetWidth() / 2, User.Center.Y - Sprite.GetHeight() / 2);
        }

        public virtual void UseUp()
        {
            Position = new Vector2(User.Center.X - Sprite.GetWidth() / 2, User.Center.Y - Constant.ItemOffset - Sprite.GetHeight() / 2);
        }

        public virtual void UseDown()
        {
            Position = new Vector2(User.Center.X - Sprite.GetWidth() / 2, User.Center.Y + Constant.ItemOffset - Sprite.GetHeight() / 2);
        }
    }
}
