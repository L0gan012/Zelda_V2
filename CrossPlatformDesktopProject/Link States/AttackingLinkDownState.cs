using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class AttackingLinkDownState : ILinkState
    {
        private ILink link;
        public ISprite Sprite { get; set; }

        public AttackingLinkDownState(ILink link)
        {
            this.link = link;
            link.PrimaryItem.UseDown();
            link.FacingDirection = Enumerations.Direction.Down;
            Sprite = LinkSpriteFactory.Instance.CreateUsingItemDownLinkSprite();
            //SoundManager.Instance.PlaySwordSlashAndShoot();
            SoundManager.Instance.PlaySwordSlash();
            SoundManager.Instance.PlaySwordShoot();
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
            link.State = new UsingItemLinkDownState(link);
        }

        public void SetLinkIdle()
        {
            link.State = new IdleLinkDownState(link);
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
