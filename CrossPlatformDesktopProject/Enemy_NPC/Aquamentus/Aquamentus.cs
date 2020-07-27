using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Aquamentus : AbstractNPC
    {
        private float limit;
        private float prevX;
        private IProjectile projectile1;
        private IProjectile projectile2;
        private IProjectile projectile3;
        private int timer;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.EnemyAquamentus;

        public Aquamentus()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentus();
            Position = Constant.EnemyStartPosition;

            DamageAmount = EnemyConstants.AquamentusDamageAmount;
            MaxHP = EnemyConstants.AquamentusHP;
            CurrentHP = MaxHP;
           
            limit = Constant.RNG.Next(EnemyConstants.MinAquamentusXRange, EnemyConstants.MaxAquamentusXRange);
            prevX = Position.X;

            Velocity = Vector2.Negate(Vector2.UnitX);

            projectile1 = new AquamentusProjectile();
            projectile2 = new AquamentusProjectile();
            projectile3 = new AquamentusProjectile();
            timer = 0;
        }

        public override void Update()
        {
            MoveAquamentus();
            FireProjectiles();
            Sprite.Update();
        }

        private void MoveAquamentus()
        {
            Position += Velocity * EnemyConstants.AquamentusSpeed;

            if (Math.Abs(Position.X - prevX) > limit || HasHitWall)
            {
                Velocity = Vector2.Negate(Velocity);
                limit = Constant.RNG.Next(EnemyConstants.MinAquamentusXRange, EnemyConstants.MaxAquamentusXRange);
                prevX = Position.X;
                HasHitWall = false;
            }
        }

        private void FireProjectiles()
        {
            if (timer == 0)
            {
                Vector2 slope = Game1.Instance.Link.Position - Position;
                slope = new Vector2(slope.X, -slope.Y);
                Vector2 unitVector = slope / (float) Math.Sqrt(Math.Pow(slope.X, 2) + Math.Pow(slope.Y, 2));
                float middleProjectileAngle = (float) -((Math.Atan2(unitVector.X, unitVector.Y)*(180/Math.PI)) - 90f);
                Vector2 middleProjectile = new Vector2(unitVector.X, -unitVector.Y);
                Vector2 upperProjectile = new Vector2((float) Math.Cos((middleProjectileAngle - EnemyConstants.AquamentusProjectileAngle) * Math.PI / 180), (float) -Math.Sin((middleProjectileAngle - EnemyConstants.AquamentusProjectileAngle) * Math.PI / 180));
                Vector2 lowerProjectile = new Vector2((float) Math.Cos((middleProjectileAngle + EnemyConstants.AquamentusProjectileAngle) * Math.PI / 180), (float) -Math.Sin((middleProjectileAngle + EnemyConstants.AquamentusProjectileAngle) * Math.PI / 180));

                projectile1.Fire(upperProjectile, Position);
                projectile2.Fire(middleProjectile, Position);
                projectile3.Fire(lowerProjectile, Position);
                Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentusMouthOpen();
            }
            if (timer == EnemyConstants.AquamentusMouthOpenTime)
            {
                Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentus();
            }
            timer++;
            if (timer >= EnemyConstants.AquamentusProjectileTime)
            {
                timer = 0;
                projectile1 = new AquamentusProjectile();
                projectile2 = new AquamentusProjectile();
                projectile3 = new AquamentusProjectile();
            }
        }

        protected override void DropItems()
        {
            Room.CurrentRoomItems.Add(new ItemHeartContainer() { Position = this.Position });
        }
    }
}
