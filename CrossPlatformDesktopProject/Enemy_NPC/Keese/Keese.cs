using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Keese : AbstractNPC
    {
        private int movementTimer = 0;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyFlying;
            set => _ = Enumerations.GameObjectType.EnemyFlying;
        }

        public Keese()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyKeese();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.KeeseDamageAmount;
            MaxHP = Constant.KeeseHP;
            CurrentHP = MaxHP;

            Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * Constant.KeeseSpeed + Vector2.UnitY * Constant.RNG.Next(-1, 2) * Constant.KeeseSpeed;
        }

        public override void Update()
        {
            MoveKeese();
            base.Update();
        }

        private void MoveKeese()
        {
            if (movementTimer == Constant.KeeseMovementTimer)
            {
                Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * Constant.KeeseSpeed + Vector2.UnitY * Constant.RNG.Next(-1, 2) * Constant.KeeseSpeed;
                movementTimer = 0;
            }
            Position += Velocity;
            movementTimer++;
        }
    }
}
