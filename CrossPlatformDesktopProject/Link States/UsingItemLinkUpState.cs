using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class UsingItemLinkUpState : ILinkState
    {
        private ILink link;
        public ISprite Sprite { get; set; }

        public UsingItemLinkUpState(ILink link)
        {
            this.link = link;
            link.Item.UseUp();
            Sprite = LinkSpriteFactory.Instance.CreateUsingItemUpLinkGreenSprite();
        }

        public void Update()
        {
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            Sprite.Draw(spriteBatch, color, link.Position);
        }

        public void DamageLink(Game1 game)
        {
            game.Link = new DamagedLink(link, game);
        }

        public void UseItem()
        {
            //Already using an item
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
            link.State = new MovingLinkUpState(link);
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
