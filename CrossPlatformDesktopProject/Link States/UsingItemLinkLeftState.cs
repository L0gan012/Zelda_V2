﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class UsingItemLinkLeftState : ILinkState
    {
        private ILink link;
        public ISprite Sprite { get; set; }

        public UsingItemLinkLeftState(ILink link)
        {
            this.link = link;
            link.SecondaryItem.UseLeft();
            link.FacingDirection = Enumerations.Direction.Left;
            Sprite = LinkSpriteFactory.Instance.CreateUsingItemLeftLinkSprite();
        }

        public void Update()
        {
            Sprite.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            Sprite.Draw(spriteBatch, color, link.Position);
        }

        public void DamageLink()
        {
            Game1.Instance.Link = new DamagedLink(link);
        }

        public void UseItem()
        {
            //Already using an item
        }

        public void SetLinkIdle()
        {
            link.State = new IdleLinkLeftState(link);
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
            link.State = new AttackingLinkLeftState(link);
        }

        public void GetItem()
        {
            link.State = new LinkGetItemState(link);
        }
    }
}
