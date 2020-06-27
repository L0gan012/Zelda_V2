using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class MovingLinkRightState : ILinkState
    {
        private ILink link;
        public ISprite Sprite { get; set; }

        public MovingLinkRightState(ILink link)
        {
            this.link = link;
            link.FacingDirection = Enumerations.Sides.right;
            link.Velocity = Vector2.UnitX * Constant.LinkMovementSpeed;
            Sprite = LinkSpriteFactory.Instance.CreateMovingRightLinkSprite();
        }

        public void Update()
        {
            if (link.Position.X < Constant.ScreenWidth - Constant.LinkWidth * Constant.DisplayScaleX)
            {
                link.Position += link.Velocity;
            }
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            Sprite.Draw(spriteBatch, color, link.Position);
        }

        public void DamageLink(Game1 game) {
            game.Link = new DamagedLink(link, game);
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
            //Already moving right
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
            link.State = new AttackingLinkRightState(link);
        }
    }
}

