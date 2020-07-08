using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class SpikeCross : AbstractNPC
    {
        private IPlayer user;
        private Vector2 originalPosition;
        private bool isSmashing;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyGround;
            set => _ = Enumerations.GameObjectType.EnemyGround;
        }

        public SpikeCross()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemySpikeCross();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.SpikeCrossDamageAmount;
            MaxHP = Constant.SpikeCrossHP;
            CurrentHP = MaxHP;

            this.user = Game1.Instance.Link;

            isSmashing = false;
        }

        public override void Update()
        {
            Smash();
            
            Position += Velocity;
            base.Update();
        }

        private void Smash()
        {
            isSmashing = true;
            originalPosition = Position;

            if (user.Center.X > Position.X && user.Center.X < Position.X + Rectangle.Width)
            {
                if(Center.Y > user.Center.Y)
                {
                    Velocity = -Vector2.UnitY * Constant.SpikeCrossCollisionSpeed;
                }
                else
                {
                    Velocity = Vector2.UnitY * Constant.SpikeCrossCollisionSpeed;
                }
            }
            if (user.Center.Y < Position.Y && user.Center.Y < Position.Y + Rectangle.Height)
            {
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
            while (!Position.Equals(originalPosition))
            {

            }
        }
    }
}
