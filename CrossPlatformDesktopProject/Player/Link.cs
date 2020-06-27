using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class Link : AbstractGameObject, ILink
    {
        private static Game1 game;

        public float MaxHP { get; set; }
        public float HP { get; set; }
        public Vector2 Velocity { get; set; }
        public ILinkState State { get; set; }
        public IUsableItem PrimaryItem { get; set; }
        public IUsableItem SecondaryItem { get; set; }

        public override ISprite Sprite
        {
            get => State.Sprite;
        }

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Enumerations.Sides FacingDirection { get; set; }

        public Link(Game1 game)
        {
            Link.game = game;

            MaxHP = Constant.LinkStartHP;
            HP = Constant.LinkStartHP;

            Position = Constant.LinkStartPosition;

            State = new IdleLinkDownState(this);
        }

        public override void Update()
        {
            if(Knockback && Vector2.Distance(Position, CollisionLocation) < Constant.LinkKnockback)
            {
                Position += Velocity;
            }
            else if (Knockback)
            {
                Knockback = false;
            }
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

        public void DamagePlayer(float damageAmount) 
        {
            HP -= damageAmount;
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