using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class Link : AbstractGameObject, ILink
    {
        private static Game1 game;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public ILinkState State { get; set; }
        public IUsableItem PrimaryItem { get; set; }
        public IUsableItem SecondaryItem { get; set; }

        public override ISprite Sprite
        {
            get
            {
                return State.Sprite;
            }
        }

        public Link(Game1 game)
        {
            Link.game = game;
            Position = Constant.LinkStartPosition;

            State = new IdleLinkDownState(this);
            Color = Color.White;
        }

        public override void Update()
        {
            if(PrimaryItem != null)
            {
                PrimaryItem.Update();
            }
            if (SecondaryItem != null)
            {
                SecondaryItem.Update();
            }
            State.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if(PrimaryItem != null)
            {
                PrimaryItem.Draw(spriteBatch);
            }
            if (SecondaryItem != null)
            {
                SecondaryItem.Draw(spriteBatch);
            }
            State.Draw(spriteBatch, Color);
        }

        public void DamagePlayer() 
        {
            State.DamageLink(game);
        }

        public void UseItem() 
        {
            State.UseItem();
        }

        public void SetIdle()
        {
            State.SetLinkIdle();
        }

        public void Attack()
        {
            State.Attack();
        }

        public void MoveLeft()
        {
            State.MoveLinkLeft();
        }

        public void MoveRight()
        {
            State.MoveLinkRight();
        }

        public void MoveUp()
        {
            State.MoveLinkUp();
        }

        public void MoveDown()
        {
            State.MoveLinkDown();
        }
    }
}