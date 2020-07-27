using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Keese : AbstractNPC
    {
        private int movementTimer = 0;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.EnemyFlying;

        public Keese()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyKeese();
            Position = Constant.EnemyStartPosition;

            DamageAmount = EnemyConstants.KeeseDamageAmount;
            MaxHP = EnemyConstants.KeeseHP;
            CurrentHP = MaxHP;

            Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * EnemyConstants.KeeseSpeed + Vector2.UnitY * Constant.RNG.Next(-1, 2) * EnemyConstants.KeeseSpeed;
        }

        public override void Update()
        {
            MoveKeese();
            base.Update();
        }

        private void MoveKeese()
        {
            if (movementTimer == EnemyConstants.KeeseMovementTimer)
            {
                Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * EnemyConstants.KeeseSpeed + Vector2.UnitY * Constant.RNG.Next(-1, 2) * EnemyConstants.KeeseSpeed;
                movementTimer = 0;
            }
            Position += Velocity;
            movementTimer++;
        }
    }
}
