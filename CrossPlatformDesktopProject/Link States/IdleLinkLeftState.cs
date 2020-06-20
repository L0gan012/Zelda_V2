﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using Sprint2.Player;

namespace Sprint2
{
    class IdleLinkLeftState : ILinkState
    {
        private ILink link;
        public ISprite Sprite { get; set; }

        public IdleLinkLeftState(ILink link)
        {
            this.link = link;
            Sprite = LinkSpriteFactory.Instance.CreateLinkIdleLeftGreenSprite();
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
            link.State = new UsingItemLinkLeftState(link);
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

        public void MoveLinkDown(){
            link.State = new MovingLinkDownState(link);
        }

        public void Attack() {
            link.State = new AttackingLinkLeftState(link);
        }
    }
}
