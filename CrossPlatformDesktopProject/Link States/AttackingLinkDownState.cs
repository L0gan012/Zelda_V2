using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using Sprint2.Player;

namespace Sprint2
{
    class AttackingLinkDownState : ILinkState
    {
        private ILink link;
        private ISprite sprite;

        public AttackingLinkDownState(ILink link)
        {
            this.link = link;
            sprite = LinkSpriteFactory.Instance.CreateAttackingDownLinkGreenSprite();
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

        public void UseItem()
        {
            link.Item.UseDown();
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
    }
}
