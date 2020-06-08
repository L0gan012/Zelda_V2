using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using Sprint2.Player;

namespace Sprint2
{
    class UsingItemLinkRightState : ILinkState
    {
        private ILink link;
        private ISprite sprite;

        public UsingItemLinkRightState(ILink link)
        {
            this.link = link;
            sprite = LinkSpriteFactory.Instance.CreateUsingItemRightLinkGreenSprite();
        }

        public void Update()
        {
            sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            sprite.Draw(spriteBatch, color, link.Position);
        }

        public void DamageLink(Game1 game)
        {
            game.Link = new DamagedLink(link, game);
        }

        public void UseItem(IItem item)
        {
            //Already using an item
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
            link.State = new AttackingLinkRightState(link);
        }
    }
}
