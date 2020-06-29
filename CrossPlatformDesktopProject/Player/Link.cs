using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class Link : AbstractGameObject, ILink
    {

        public float MaxHP { get; set; }
        public float HP { get; set; }
        public ILinkState State { get; set; }
        public IUsableItem PrimaryItem { get; set; }
        public IUsableItem SecondaryItem { get; set; }

        public override ISprite Sprite
        {
            get => State.Sprite;
        }

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Player;
            set => _ = Enumerations.GameObjectType.Player;
        }

        public Enumerations.Sides FacingDirection { get; set; }

        public Link()
        {

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
            State.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch, Color);
        }

        public void DamagePlayer(float damageAmount) 
        {
            HP -= damageAmount;
            State.DamageLink();
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