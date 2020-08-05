using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Rope : AbstractNPC
    {
        private Enumerations.Direction facingDirection;
        private int movementTimer;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.EnemyGround;

        public Rope()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyRopeLeft();
            Position = Constant.EnemyStartPosition;
            Velocity = Vector2.UnitX * EnemyConstants.RopeNormalSpeed;
            facingDirection = Enumerations.Direction.Left;
            movementTimer = 0;
            DamageAmount = EnemyConstants.RopeDamageAmount;
        }

        public override void Update()
        {
            MoveRope();
            SpotPlayer();
            base.Update();
        }

        private void MoveRope()
        {
            if (movementTimer == EnemyConstants.RopeMovementTimer)
            {
                Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * EnemyConstants.RopeNormalSpeed;
                if (Velocity.X.Equals(0f))
                {
                    while (Velocity.Equals(Vector2.Zero))
                    {
                        Velocity = Vector2.UnitY * Constant.RNG.Next(-1, 2) * EnemyConstants.RopeNormalSpeed;
                    }
                    if (Velocity.Y > 0)
                    {
                        facingDirection = Enumerations.Direction.Down;
                    }
                    else
                    {
                        facingDirection = Enumerations.Direction.Up;
                    }
                }
                else
                {
                    if (Velocity.X > 0)
                    {
                        facingDirection = Enumerations.Direction.Right;
                        Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyRopeRight();
                    }
                    else
                    {
                        facingDirection = Enumerations.Direction.Left;
                        Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyRopeLeft();
                    }
                }
                movementTimer = 0;
            }
            if (HasHitWall)
            {
                HasHitWall = false;
                TurnRight(EnemyConstants.RopeNormalSpeed);
            }
            Position += Velocity;
            movementTimer++;
        }

        private void SpotPlayer()
        {
            if(Game1.Instance.Link.Position.X == Position.X)
            {
                if(Game1.Instance.Link.Position.Y > Position.Y)
                {
                    Velocity = Vector2.UnitY * EnemyConstants.RopeFastSpeed;
                }
                else
                {
                    Velocity = -Vector2.UnitY * EnemyConstants.RopeFastSpeed;
                }
            }
            else if(Game1.Instance.Link.Position.Y == Position.Y)
            {
                if (Game1.Instance.Link.Position.X > Position.X)
                {
                    Velocity = Vector2.UnitX * EnemyConstants.RopeFastSpeed;
                }
                else
                {
                    Velocity = -Vector2.UnitX * EnemyConstants.RopeFastSpeed;
                }
            }
        }
    }
}
