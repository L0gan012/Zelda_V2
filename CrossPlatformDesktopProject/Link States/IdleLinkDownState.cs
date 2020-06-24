using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class IdleLinkDownState : ILinkState
    {
        private ILink link;
        public ISprite Sprite { get; set; }

        public IdleLinkDownState(ILink link)
        {
            this.link = link;
            Sprite = LinkSpriteFactory.Instance.CreateLinkIdleDownSprite();
        }

        public void Update(){
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Color color){
            Sprite.Draw(spriteBatch, color, link.Position);
        }

        public void DamageLink(Game1 game){
            game.Link = new DamagedLink(link, game);
        }

        public void UseItem()
        {
            link.State = new UsingItemLinkDownState(link);
        }

        public void SetLinkIdle(){
            //NO-OP
            //Already idle
        }

        public void MoveLinkLeft(){
            link.State = new MovingLinkLeftState(link);
        }

        public void MoveLinkRight(){
            link.State = new MovingLinkRightState(link);
        }

        public void MoveLinkUp(){
            link.State = new MovingLinkUpState(link);
        }

        public void MoveLinkDown()
        {
            link.State = new MovingLinkDownState(link);
        }

        public void Attack() {
            link.State = new AttackingLinkDownState(link);
        }
    }
}
