using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class AquamentusProjectile : AbstractGameObject, IProjectile
    {
        private int timer;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ProjectileVsPlayer;

        public AquamentusProjectile()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileFlame();
            timer = 0;
        }

        public void Fire(Vector2 direction, Vector2 startPosition)
        {
            Position = startPosition;
            Velocity = direction * Constant.AqumentusProjectileSpeed;
            RoomClass.CurrentRoomProjectiles.Add(this);
        }

        private void Move()
        {
            Position += Velocity;
            timer++;
            if(timer >= Constant.AquamentusProjectileTime)
            {
                IsDestructable = true;
            }
        }

        public override void Update()
        {
            Move();
            base.Update();
        }

    }
}
