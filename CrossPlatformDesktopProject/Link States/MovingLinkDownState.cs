using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using Sprint2.Player;

namespace Sprint2
{
    class MovingLinkDownState : ILinkState
    {
        private ILink link;
        private ISprite sprite;

        public MovingLinkDownState(ILink link)
        {
            this.link = link;
            sprite = LinkSpriteFactory.Instance.CreateMovingDownLinkGreenSprite();
        }

        public void Update()
        {
            if (link.Position.Y < Constant.ScreenHeight - Constant.LinkHeight * Constant.DisplayScaleY)
            {
                link.Position = new Vector2(link.Position.X, link.Position.Y + 1 * Constant.LinkMovementSpeed);
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
    }
}
