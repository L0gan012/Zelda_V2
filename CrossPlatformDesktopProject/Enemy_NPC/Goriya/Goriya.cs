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
            Velocity = Vector2.UnitY * Constant.GoriyaSpeed;
            facingDirection = Enumerations.Direction.down;
            movementTimer = 0;
        }

        public override void Update()
        {
            MoveGoriya();
            ThrowBoomerang();

            base.Update();
        }

        private void MoveGoriya()
        {
            if (movementTimer == Constant.GoriyaMovementTimer)
            {
                Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * Constant.GoriyaSpeed;
                if (Velocity.X.Equals(0f))
                {
                    while (Velocity.Equals(Vector2.Zero))
                    {
                        Velocity = Vector2.UnitY * Constant.RNG.Next(-1, 2) * Constant.GoriyaSpeed;
                    }
                    if(Velocity.Y > 0)
                    {
                        facingDirection = Enumerations.Direction.down;
                        Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGoriyaWalkDown();
                    }
                    else
                    {
                        facingDirection = Enumerations.Direction.up;
                        Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGoriyaWalkUp();
                    }
                }
                else
                {
                    if(Velocity.X > 0)
                    {
                        facingDirection = Enumerations.Direction.right;
                        Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGoriyaWalkRight();
                    }
                    else
                    {
                        facingDirection = Enumerations.Direction.left;
                        Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGoriyaWalkLeft();
                    }
                }
                movementTimer = 0;
            }
            Position += Velocity;
            movementTimer++;
        }

        private void ThrowBoomerang()
        {
            if (Constant.RNG.Next(0, 1000) < 5)
            {
                boomerang = new UsableBoomerang(this);
                boomerang.GameObjectType = Enumerations.GameObjectType.UsableItemVsPlayer;

                switch (facingDirection)
                {
                    case Enumerations.Direction.up:
                        boomerang.UseUp();
                        break;
                    case Enumerations.Direction.down:
                        boomerang.UseDown();
                        break;
                    case Enumerations.Direction.left:
                        boomerang.UseLeft();
                        break;
                    case Enumerations.Direction.right:
                        boomerang.UseRight();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
