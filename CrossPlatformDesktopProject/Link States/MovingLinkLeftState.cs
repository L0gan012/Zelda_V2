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
            Sprite = LinkSpriteFactory.Instance.CreateMovingLeftLinkGreenSprite();
        }

        public void Update()
        {
            if (link.Position.X > 0)
            {
                link.Position = new Vector2(link.Position.X - 1 * Constant.LinkMovementSpeed, link.Position.Y);
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
