using System;
namespace Sprint2
{
    public abstract class AbstractNPC : AbstractGameObject, INPC
    {
        protected float maxHP { get; set; }
        protected float currentHP { get; set; }

        public float DamageAmount { get; set; }

        public void TakeDamage(float damageAmount)
        {
            currentHP -= DamageAmount;
            if (currentHP <= 0)
            {
                IsDestructable = true;
            }
        }

    }
}
