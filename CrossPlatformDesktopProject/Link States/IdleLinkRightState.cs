﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using Sprint2.Player;

namespace Sprint2
{
    class IdleLinkRightState : ILinkState
    {
        private ILink link;
        private ISprite sprite;

        public IdleLinkRightState(ILink link)
        {
            this.link = link;
            sprite = LinkSpriteFactory.Instance.CreateLinkIdleRightGreenSprite();
        }

        public void Update(){
            sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Color color){
            sprite.Draw(spriteBatch, color, link.Position);
        }

        public void DamageLink(Game1 game){
            game.Link = new DamagedLink(link, game);
        }

        public void UseItem()
        {
            link.Item.Use();
            link.State = new UsingItemLinkRightState(link);
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
            link.State = new AttackingLinkRightState(link);
        }
    }
}
