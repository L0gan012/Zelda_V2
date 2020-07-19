using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class Link : AbstractGameObject, ILink
    {
        public float MaxHP { get; set; }
        public ILinkState State { get; set; }
        public IUsableItem PrimaryItem { get; set; }
        public IUsableItem SecondaryItem { get; set; }
        public IInventory Inventory { get; }
        public override ISprite Sprite { get => State.Sprite; }
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Player;
        public Enumerations.Direction FacingDirection { get; set; }
        //public float HP { get; set; }

        private float hp;
        public float HP
        {
            get => hp;
            set
            {
                hp = value;
                if(value < 0)
                {
                    hp = 0;
                }
            }
        }


        public Link()
        {
            MaxHP = Constant.LinkStartHP;
            HP = Constant.LinkStartHP;
            State = new IdleLinkDownState(this);

            Inventory = new Inventory();

            Position = Constant.LinkStartPosition;
            FacingDirection = Enumerations.Direction.Down;

            SecondaryItem = new UsableBlueCandle(this);
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
                switch (FacingDirection)
                {
                    case Enumerations.Direction.Left:
                        Velocity = -Vector2.UnitX * Constant.LinkMovementSpeed;
                        break;
                    case Enumerations.Direction.Right:
                        Velocity = Vector2.UnitX * Constant.LinkMovementSpeed;
                        break;
                    case Enumerations.Direction.Up:
                        Velocity = -Vector2.UnitY * Constant.LinkMovementSpeed;
                        break;
                    case Enumerations.Direction.Down:
                        Velocity = Vector2.UnitY * Constant.LinkMovementSpeed;
                        break;
                    default:
                        break;
                }
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
            SecondaryItem.IsDestructable = false;
            if(!Room.CurrentRoomUsableItems.Contains(SecondaryItem) || SecondaryItem.Equals(new UsableBomb(this)))
            {
                State.UseItem();
            }
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