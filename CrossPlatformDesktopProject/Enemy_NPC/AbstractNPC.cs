using System;
namespace Sprint2
{
    public abstract class AbstractNPC : AbstractGameObject, INPC
    {
        protected float MaxHP { get; set; }
        protected float CurrentHP { get; set; }

        public float DamageAmount { get; set; }

        public void TakeDamage(float damageAmount)
        {
            CurrentHP -= DamageAmount;
            if (CurrentHP <= 0)
            {
                IsDestructable = true;
            }
        }

    }
}
