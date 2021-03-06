﻿using Microsoft.Xna.Framework;

namespace Sprint2
{
    public abstract class AbstractNPC : AbstractGameObject, INPC
    {
        protected float MaxHP { get; set; }
        protected float CurrentHP { get; set; }
        public float DamageAmount { get; set; }
        public bool HasKey { get; set; } = false;
        public bool HasHitWall { get; set; } = false;

        public override void Update()
        {
            if (Knockback && Vector2.Distance(Position, CollisionLocation) < Constant.BlockKnockback)
            {
                Position += Velocity;
            }
            else if (Knockback)
            {
                Knockback = false;
            }
            base.Update();
        }

        public virtual void TakeDamage(float damageAmount)
        {
            CurrentHP -= DamageAmount;
            if (CurrentHP <= 0)
            {
                IsDestructable = true;
                SoundManager.Instance.PlayEnemyDie();
                Room.CurrentRoomSpriteEffects.Add(new EffectEnemyDeath(this.Position));
                DropItems();
                Game1.Instance.currentScore++;
            }
        }

        protected virtual void DropItems()
        {
            if (HasKey)
            {
                Room.CurrentRoomItems.Add(new ItemKey());
            }
            else
            {
                int whichDrop = Constant.RNG.Next(0, ItemConstants.ItemDropChance);

                switch (whichDrop)
                {
                    case 0:
                        Room.CurrentRoomItems.Add(new ItemFairy() { Position = this.Position });
                        break;
                    case 1:
                        Room.CurrentRoomItems.Add(new ItemHeart() { Position = this.Position });
                        break;
                    case 2:
                        Room.CurrentRoomItems.Add(new ItemBomb() { Position = this.Position });
                        break;
                    case 3:
                        Room.CurrentRoomItems.Add(new ItemRupee { Position = this.Position });
                        break;
                    case 4:
                        Room.CurrentRoomItems.Add(new ItemFiveRupee { Position = this.Position });
                        break;
                    default:
                        break;
                }
            }
        }

        public void TurnRight(float speed)
        {
            if (Velocity.X > 0)
            {
                Velocity = -Vector2.UnitY * speed;
            }
            else if (Velocity.X < 0)
            {
                Velocity = Vector2.UnitY * speed;
            }
            else if (Velocity.Y > 0)
            {
                Velocity = Vector2.UnitX * speed;
            }
            else if (Velocity.Y < 0)
            {
                Velocity = -Vector2.UnitX * speed;
            }
        }
    }
}
 