using Microsoft.Xna.Framework;

namespace Sprint2
{
    public abstract class AbstractUsable : AbstractItem, IUsableItem
    {
        protected ILink Link { get; set; }


        public virtual void UseLeft()
        {
            Location = new Vector2(Link.Center.X - Constant.ItemOffset - Sprite.GetWidth() / 2, Link.Center.Y - Sprite.GetHeight() / 2);
        }

        public virtual void UseRight()
        {
            Location = new Vector2(Link.Center.X + Constant.ItemOffset - Sprite.GetWidth() / 2, Link.Center.Y - Sprite.GetHeight() / 2);
        }

        public virtual void UseUp()
        {
            Location = new Vector2(Link.Center.X - Sprite.GetWidth() / 2, Link.Center.Y - Constant.ItemOffset - Sprite.GetHeight() / 2);
        }

        public virtual void UseDown()
        {
            Location = new Vector2(Link.Center.X - Sprite.GetWidth() / 2, Link.Center.Y + Constant.ItemOffset - Sprite.GetHeight() / 2);
        }
    }
}
