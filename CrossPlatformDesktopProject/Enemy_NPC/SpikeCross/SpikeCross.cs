using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class SpikeCross : AbstractNPC
    {
        private IPlayer user;
        private Vector2 originalPosition;
        private bool isSmashing;
        private bool isRetracting;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.EnemyGround;

        public SpikeCross()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemySpikeCross();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.SpikeCrossDamageAmount;
            MaxHP = Constant.SpikeCrossHP;
            CurrentHP = MaxHP;

            this.user = Game1.Instance.Link;

            isSmashing = false;
            isRetracting = false;
        }

        public override void Update()
        {
            MoveSpikeCross();
            base.Update();
        }

        private void Smash()
        {
            originalPosition = Position;

            if (user.Center.X > Position.X && user.Center.X < Position.X + Rectangle.Width)
            {
                isSmashing = true;
                if (Center.Y > user.Center.Y)
                {
                    Velocity = -Vector2.UnitY * Constant.SpikeCrossCollisionSpeed;
                }
                else
                {
                    Velocity = Vector2.UnitY * Constant.SpikeCrossCollisionSpeed;
                }
            }
            if (user.Center.Y > Position.Y && user.Center.Y < Position.Y + Rectangle.Height)
            {
                isSmashing = true;
                if (Center.X > user.Center.X)
                {
                    Velocity = -Vector2.UnitX * Constant.SpikeCrossCollisionSpeed;
                }
                else
                {
                    Velocity = Vector2.UnitX * Constant.SpikeCrossCollisionSpeed;
                }
            }
        }

        private void Retract()
        {
            isSmashing = false;
            isRetracting = true;

            Velocity = -Velocity / Constant.SpikeCrossCollisionSpeed * Constant.SpikeCrossRetractionSpeed;
        }

        private void MoveSpikeCross()
        {
            if (!isSmashing && !isRetracting)
            {
                Smash();
            }
            else if ((Math.Abs(Position.X - originalPosition.X) > Constant.DungeonFloorWidth / 2 || Math.Abs(Position.Y - originalPosition.Y) > Constant.DungeonFloorHeight / 2) && isSmashing)
            {
                Retract();
            }
            else if (Position.Equals(originalPosition) && isRetracting)
            {
                isRetracting = false;
                Velocity = Vector2.Zero;
            }
            Position += Velocity;
        }
    }
}
