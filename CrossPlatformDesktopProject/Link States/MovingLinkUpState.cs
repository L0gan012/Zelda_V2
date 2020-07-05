using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class MovingLinkUpState : ILinkState
    {
        private ILink link;
        public ISprite Sprite { get; set; }

        public MovingLinkUpState(ILink link)
        {
            this.link = link;
            link.FacingDirection = Enumerations.CollisionSide.Top;
            link.Velocity = -Vector2.UnitY * Constant.LinkMovementSpeed;
            Sprite = LinkSpriteFactory.Instance.CreateMovingUpLinkSprite();
        }

        public void Update()
        {
            if (link.Position.Y > 0)
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
            link.State = new UsingItemLinkUpState(link);
        }

        public void SetLinkIdle()
        {
            link.State = new IdleLinkUpState(link);
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
            //Already moving up
        }

        public void MoveLinkDown()
        {
            link.State = new MovingLinkDownState(link);
        }

        public void Attack()
        {
            link.State = new AttackingLinkUpState(link);
        }
    }
}