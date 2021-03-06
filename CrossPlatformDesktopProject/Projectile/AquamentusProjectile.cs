﻿using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class AquamentusProjectile : AbstractGameObject, IProjectile
    {
        private int timer;

        public float DamageAmount { get; }
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ProjectileVsPlayer;

        public AquamentusProjectile()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileFlame();
            timer = 0;
            DamageAmount = EnemyConstants.AquamentusProjectileDamageAmount;
        }

        public override void Update()
        {
            Move();
            base.Update();
        }

        public void Fire(Vector2 direction, Vector2 startPosition)
        {
            Position = startPosition;
            Velocity = direction * EnemyConstants.AqumentusProjectileSpeed;
            Room.CurrentRoomProjectiles.Add(this);
        }

        private void Move()
        {
            Position += Velocity;
            timer++;
            if(timer >= EnemyConstants.AquamentusProjectileTime)
            {
                IsDestructable = true;
            }
        }
    }
}
