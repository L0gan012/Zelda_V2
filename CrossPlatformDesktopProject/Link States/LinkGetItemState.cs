using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class LinkGetItemState : ILinkState
    {
        private ILink link;
        public ISprite Sprite { get; set; }

        public LinkGetItemState(ILink link)
        {
            this.link = link;
            link.FacingDirection = Enumerations.Direction.Down;
            Sprite = LinkSpriteFactory.Instance.CreateGetItemLinkSprite();
        }

        public void Update()
        {
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            Sprite.Draw(spriteBatch, color, link.Position);
        }

        public void GetItem()
        {
            //Can't get item
        }

        public void MoveLinkDown()
        {
            //Can't move
        }

        public void MoveLinkLeft()
        {
            //Can't move
        }

        public void MoveLinkRight()
        {
            //Can't move
        }

        public void MoveLinkUp()
        {
            //Can't move
        }

        public void SetLinkIdle()
        {
            link.State = new IdleLinkDownState(link);
        }

        public void Attack()
        {
            //Can't attack
        }

        public void DamageLink()
        {
            //Csn't be damaged
        }

        public void UseItem()
        {
            //Can't use item
        }
    }
}
