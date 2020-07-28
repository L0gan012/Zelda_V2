using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Stalfos : AbstractNPC
    {
        private int movementTimer = 0;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.EnemyGround;

        public Stalfos()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyStalfos();
            Position = Constant.EnemyStartPosition;

            DamageAmount = EnemyConstants.StalfosDamageAmount;
            MaxHP = EnemyConstants.StalfosHP;
            CurrentHP = MaxHP;

            Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * EnemyConstants.StalfosSpeed;
            if (Velocity.X.Equals(0f))
            {
                while (Velocity.Equals(Vector2.Zero))
                {
                    Velocity = Vector2.UnitY * Constant.RNG.Next(-1, 2) * EnemyConstants.StalfosSpeed;
                }
            }
        }

        public override void Update()
        {
            MoveStalfos();
            base.Update();
        }

        private void MoveStalfos()
        {
            if (movementTimer == EnemyConstants.StalfosMovementTimer)
            {
                Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * EnemyConstants.StalfosSpeed;
                if (Velocity.X.Equals(0f))
                {
                    while (Velocity.Equals(Vector2.Zero))
                    {
                        Velocity = Vector2.UnitY * Constant.RNG.Next(-1, 2) * EnemyConstants.StalfosSpeed;
                    }
                }
                movementTimer = 0;
            }
            if (HasHitWall)
            {
                HasHitWall = false;
                TurnRight(EnemyConstants.StalfosSpeed);
            }
            Position += Velocity;
            movementTimer++;
        }
    }
}
