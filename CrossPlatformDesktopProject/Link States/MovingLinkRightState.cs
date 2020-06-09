using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using Sprint2.Player;

namespace Sprint2
{
    class MovingLinkRightState : ILinkState
    {
        private ILink link;
        private ISprite sprite;

        public MovingLinkRightState(ILink link)
        {
            this.link = link;
            sprite = LinkSpriteFactory.Instance.CreateMovingRightLinkGreenSprite();
        }

        public void Update()
        {
            if (link.Position.X < Constant.ScreenWidth - Constant.LinkWidth)
            {
                link.Position = new Vector2(link.Position.X + 1 * Constant.LinkMovementSpeed, link.Position.Y);
            }
            sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            sprite.Draw(spriteBatch, color, link.Position);
        }

        public void DamageLink(Game1 game) {
            game.Link = new DamagedLink(link, game);
        }

        public void UseItem(IItem item)
        {
            item.Use();
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

