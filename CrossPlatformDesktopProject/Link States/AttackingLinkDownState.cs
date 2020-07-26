using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class AttackingLinkDownState : ILinkState
    {
        private ILink link;
        private int animationTimer;

        public ISprite Sprite { get; set; }

        public AttackingLinkDownState(ILink link)
        {
            this.link = link;
            link.PrimaryItem.UseDown();
            link.FacingDirection = Enumerations.Direction.Down;
            Sprite = LinkSpriteFactory.Instance.CreateAttackingDownLinkSprite();
            animationTimer = 0;
            SoundManager.Instance.PlaySwordSlash();
        }

        public void Update()
        {
            animationTimer++;
            if (animationTimer >= Sprite.TotalFrames * Sprite.TicksPerFrame)
            {
                SetLinkIdle();
            }
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
            if (animationTimer >= Sprite.TotalFrames * Sprite.TicksPerFrame)
            {
                link.State = new UsingItemLinkDownState(link);
            }
        }

        public void SetLinkIdle()
        {
            if (animationTimer >= Sprite.TotalFrames * Sprite.TicksPerFrame)
            {
                link.State = new IdleLinkDownState(link);
            }
        }

        public void MoveLinkLeft()
        {
            if (animationTimer >= Sprite.TotalFrames * Sprite.TicksPerFrame)
            {
                link.State = new MovingLinkLeftState(link);
            }
        }

        public void MoveLinkRight()
        {
            if (animationTimer >= Sprite.TotalFrames * Sprite.TicksPerFrame)
            {
                link.State = new MovingLinkRightState(link);
            }
        }

        public void MoveLinkUp()
        {
            if (animationTimer >= Sprite.TotalFrames * Sprite.TicksPerFrame)
            {
                link.State = new MovingLinkUpState(link);
            }
        }

        public void MoveLinkDown()
        {
            if (animationTimer >= Sprite.TotalFrames * Sprite.TicksPerFrame)
            {
                link.State = new MovingLinkDownState(link);
            }
        }

        public void Attack()
        {
            //cannot attack from attack state
        }

        public void GetItem()
        {
            link.State = new LinkGetItemState(link);
        }
    }
}
