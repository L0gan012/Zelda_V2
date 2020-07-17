using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class AttackingLinkRightState : ILinkState
    {
        private ILink link;
        public ISprite Sprite { get; set; }

        public AttackingLinkRightState(ILink link)
        {
            this.link = link;
            link.PrimaryItem.UseRight();
            link.FacingDirection = Enumerations.Direction.Right;
            Sprite = LinkSpriteFactory.Instance.CreateUsingItemRightLinkSprite();
            SoundManager.Instance.PlaySwordSlash();
        }

        public void Update()
        {
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            Sprite.Draw(spriteBatch, color, link.Position);
        }

        public void DamageLink() 
        {
            Game1.Instance.Link = new DamagedLink(link);
        }

        public void UseItem()
        {
            link.State = new UsingItemLinkRightState(link);
        }

        public void SetLinkIdle()
        {
            link.State = new IdleLinkRightState(link);
        }

        public void MoveLinkLeft()
        {
            link.State = new MovingLinkLeftState(link);
        }

        public void MoveLinkRight()
        {
            link.State = new MovingLinkRightState(link);
        }

        public void MoveLinkUp()
        {
            link.State = new MovingLinkUpState(link);
        }

        public void MoveLinkDown()
        {
            link.State = new MovingLinkDownState(link);
        }

        public void Attack()
        {
            //cannot attack from attack state
        }

        public void GetItem()
        {
            link.State = new LinkGetItemState(link);
        }
    }
}
