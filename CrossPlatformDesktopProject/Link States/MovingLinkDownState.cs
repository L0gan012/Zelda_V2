using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class MovingLinkDownState : ILinkState
    {
        private ILink link;
        public ISprite Sprite { get; set; }

        public MovingLinkDownState(ILink link)
        {
            this.link = link;
            link.FacingDirection = Enumerations.Direction.Down;
            link.Velocity = Vector2.UnitY * Constant.LinkMovementSpeed;
            Sprite = LinkSpriteFactory.Instance.CreateMovingDownLinkSprite();
        }

        public void Update()
        {
            if (link.Position.Y < Constant.ScreenHeight - Constant.LinkHeight * Constant.DisplayScaleY)
            {
                link.Position += link.Velocity;
            }
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            Sprite.Draw(spriteBatch, color, link.Position);
        }

        public void DamageLink() {
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
            //Already moving down
        }

        public void Attack()
        {
            link.State = new AttackingLinkDownState(link);
        }

        public void GetItem()
        {
            link.State = new LinkGetItemState(link);
        }
    }
}
