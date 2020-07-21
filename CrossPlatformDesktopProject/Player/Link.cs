using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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
                if(value > MaxHP)
                {
                    hp = MaxHP;
                }
            }
        }


        public Link()
        {
            MaxHP = Constant.LinkStartHP;
            HP = Constant.LinkStartHP;
            State = new IdleLinkUpState(this);

            Inventory = new Inventory();
            Inventory.ItemCache.Add(new ItemBlueCandle(), new UsableBlueCandle(this));
            Inventory.HasArrows = true;

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
            if(!Room.CurrentRoomUsableItems.Contains(SecondaryItem))
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