﻿
namespace Sprint2
{
    public interface INPC : IGameObject
    {
        float DamageAmount { get; }

        void TakeDamage(int damageAmount);
    }
}
