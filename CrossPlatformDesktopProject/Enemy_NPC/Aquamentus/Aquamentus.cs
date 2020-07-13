using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Aquamentus : AbstractNPC
    {
        private bool left;
        private float limit;
        private int deltaX;
        private float prevX;
        private IProjectile projectile1;
        private IProjectile projectile2;
        private IProjectile projectile3;
        private int timer;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyAquamentus;
            set => _ = Enumerations.GameObjectType.EnemyAquamentus;
        }

        public Aquamentus()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentus();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.AquamentusDamageAmount;
            MaxHP = Constant.AquamentusHP;
            CurrentHP = MaxHP;
           
            left = true;
            deltaX = -1;
            limit = Constant.RNG.Next(Constant.MinAquamentusXRange, Constant.MaxAquamentusXRange);
            prevX = Position.X;
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
            Position = new Vector2(Position.X + deltaX * Constant.AquamentusSpeed, Position.Y);

            if (Math.Abs(Position.X - prevX) > limit)
            {
                left = !left;
                deltaX = -deltaX;
                limit = Constant.RNG.Next(Constant.MinAquamentusXRange, Constant.MaxAquamentusXRange);
                prevX = Position.X;
            }
        }

        private void FireProjectiles()
        {
            if (timer == 0)
            {
                projectile1.Fire(new Vector2(-1, -1), Position);
                projectile2.Fire(new Vector2(-1, 0), Position);
                projectile3.Fire(new Vector2(-1, 1), Position);
                Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentusMouthOpen();
            }
            if (timer == Constant.AquamentusMouthOpenTime)
            {
                Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentus();
            }
            timer++;
            if (timer >= Constant.AquamentusProjectileTime)
            {
                timer = 0;
                projectile1 = new AquamentusProjectile();
                projectile2 = new AquamentusProjectile();
                projectile3 = new AquamentusProjectile();
            }

        }

        protected override void DropItems()
        {
            RoomClass.CurrentRoomItems.Add(new ItemHeartContainer());
        }

    }
}
