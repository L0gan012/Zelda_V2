using Microsoft.Xna.Framework;

namespace Sprint2
{
    public abstract class AbstractNPC : AbstractGameObject, INPC
    {
        protected float MaxHP { get; set; }
        protected float CurrentHP { get; set; }

        public float DamageAmount { get; set; }
        public bool HasKey { get; set; } = false;

        public virtual void TakeDamage(float damageAmount)
        {
            CurrentHP -= DamageAmount;
            if (CurrentHP <= 0)
            {
                IsDestructable = true;
                SoundManager.Instance.PlayEnemyDie();
                DropItems();
            }
        }

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

        protected virtual void DropItems()
        {
            if (HasKey)
            {
                Room.CurrentRoomItems.Add(new ItemKey());
            }
            else
            {
                int whichDrop = Constant.RNG.Next(0, Constant.ItemDropChance);

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
                    default:
                        break;
                }
            }
        }

    }
}
