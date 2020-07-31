using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Zol : AbstractNPC
    {
        private int movementTimer = 0;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.EnemyGround;

        public Zol()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyZol();
            Position = Constant.EnemyStartPosition;

            DamageAmount = EnemyConstants.ZolDamageAmount;
            MaxHP = EnemyConstants.ZolHP;
            CurrentHP = MaxHP;
        }

        public override void Update()
        {
            MoveZol();
            base.Update();
        }

        private void MoveZol()
        {
            if (movementTimer == EnemyConstants.ZolMovementTimer)
            {
                Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * EnemyConstants.ZolSpeed;
                if (Velocity.X.Equals(0f))
                {
                    Velocity = Vector2.UnitY * Constant.RNG.Next(-1, 2) * EnemyConstants.ZolSpeed;
                }
                movementTimer = 0;
            }
            if (HasHitWall)
            {
                HasHitWall = false;
                TurnRight(EnemyConstants.ZolSpeed);
            }
            Position += Velocity;
            movementTimer++;
        }
    }
}
