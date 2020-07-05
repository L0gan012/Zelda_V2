using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class MovingLinkLeftState : ILinkState
    {
        private ILink link;
        public ISprite Sprite { get; set; }

        public MovingLinkLeftState(ILink link)
        {
            this.link = link;
            link.FacingDirection = Enumerations.CollisionSide.Left;
            link.Velocity = -Vector2.UnitX * Constant.LinkMovementSpeed;
            Sprite = LinkSpriteFactory.Instance.CreateMovingLeftLinkSprite();
        }

        public void Update()
        {
            if (link.Position.X > 0)
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
            link.State = new UsingItemLinkLeftState(link);
        }

        public void SetLinkIdle()
        {
            link.State = new IdleLinkLeftState(link);
        }

        public void MoveLinkLeft()
        {
            //Already moving left
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
            link.State = new AttackingLinkLeftState(link);
        }
    }
}
