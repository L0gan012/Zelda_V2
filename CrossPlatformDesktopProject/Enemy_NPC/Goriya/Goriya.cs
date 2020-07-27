using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Goriya : AbstractNPC
    {
        private IUsableItem boomerang;
        private Enumerations.Direction facingDirection;
        private int movementTimer;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.EnemyGround;

        public Goriya()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGoriyaWalkDown();
            Position = Constant.EnemyStartPosition;
            Velocity = Vector2.UnitY * EnemyConstants.GoriyaSpeed;
            facingDirection = Enumerations.Direction.Down;
            movementTimer = 0;
            DamageAmount = EnemyConstants.GoriyaDamageAmount;
        }

        public override void Update()
        {
            MoveGoriya();
            ThrowBoomerang();

            base.Update();
        }

        private void MoveGoriya()
        {
            if (movementTimer == EnemyConstants.GoriyaMovementTimer)
            {
                Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * EnemyConstants.GoriyaSpeed;
                if (Velocity.X.Equals(0f))
                {
                    while (Velocity.Equals(Vector2.Zero))
                    {
                        Velocity = Vector2.UnitY * Constant.RNG.Next(-1, 2) * EnemyConstants.GoriyaSpeed;
                    }
                    if(Velocity.Y > 0)
                    {
                        facingDirection = Enumerations.Direction.Down;
                        Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGoriyaWalkDown();
                    }
                    else
                    {
                        facingDirection = Enumerations.Direction.Up;
                        Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGoriyaWalkUp();
                    }
                }
                else
                {
                    if(Velocity.X > 0)
                    {
                        facingDirection = Enumerations.Direction.Right;
                        Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGoriyaWalkRight();
                    }
                    else
                    {
                        facingDirection = Enumerations.Direction.Left;
                        Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGoriyaWalkLeft();
                    }
                }
                movementTimer = 0;
            }
            if (HasHitWall)
            {
                HasHitWall = false;
                TurnRight(EnemyConstants.GoriyaSpeed);
            }
            Position += Velocity;
            movementTimer++;
        }

        private void ThrowBoomerang()
        {
            if (Constant.RNG.Next(0, 1000) < 5)
            {
                Velocity = Vector2.Zero;

                boomerang = new UsableBoomerang(this);
                boomerang.GameObjectType = Enumerations.GameObjectType.UsableItemVsPlayer;

                switch (facingDirection)
                {
                    case Enumerations.Direction.Up:
                        boomerang.UseUp();
                        break;
                    case Enumerations.Direction.Down:
                        boomerang.UseDown();
                        break;
                    case Enumerations.Direction.Left:
                        boomerang.UseLeft();
                        break;
                    case Enumerations.Direction.Right:
                        boomerang.UseRight();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
