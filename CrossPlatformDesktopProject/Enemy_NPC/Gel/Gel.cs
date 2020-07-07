using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Gel : AbstractNPC
    {
        private int movementTimer = 0;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyGround;
            set => _ = Enumerations.GameObjectType.EnemyGround;
        }

        public Gel()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGel();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.GelDamageAmount;
            MaxHP = Constant.GelHP;
            CurrentHP = MaxHP;

            Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * Constant.GelSpeed;
            if (Velocity.X.Equals(0f))
            {
                Velocity += Vector2.UnitY * Constant.RNG.Next(-1, 2) * Constant.GelSpeed;
            }
        }

        public override void Update()
        {
            MoveGel();
            base.Update();
        }

        private void MoveGel()
        {
            if(movementTimer == Constant.GelMovementTimer)
            {
                Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * Constant.GelSpeed;
                if (Velocity.X.Equals(0f))
                {
                    Velocity += Vector2.UnitY * Constant.RNG.Next(-1, 2) * Constant.GelSpeed;
                }
                movementTimer = 0;
            }
            Position += Velocity;
            movementTimer++;
        }
    }
}
