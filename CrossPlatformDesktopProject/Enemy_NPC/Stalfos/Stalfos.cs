using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Stalfos : AbstractNPC
    {
        private int movementTimer = 0;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyGround;
            set => _ = Enumerations.GameObjectType.EnemyGround;
        }

        public Stalfos()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyStalfos();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.StalfosDamageAmount;
            MaxHP = Constant.StalfosHP;
            CurrentHP = MaxHP;

            Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * Constant.StalfosSpeed;
            if (Velocity.X.Equals(0f))
            {
                while (Velocity.Equals(Vector2.Zero))
                {
                    Velocity = Vector2.UnitY * Constant.RNG.Next(-1, 2) * Constant.StalfosSpeed;
                }
            }
        }

        public override void Update()
        {
            if (movementTimer == Constant.StalfosMovementTimer)
            {
                MoveStalfos();
                movementTimer = 0;
            }
            movementTimer++;
            Position += Velocity;

            base.Update();
        }

        private void MoveStalfos()
        {
            Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * Constant.StalfosSpeed;
            if (Velocity.X.Equals(0f))
            {
                while (Velocity.Equals(Vector2.Zero))
                {
                    Velocity = Vector2.UnitY * Constant.RNG.Next(-1, 2) * Constant.StalfosSpeed;
                }
            }
        }
    }
}
