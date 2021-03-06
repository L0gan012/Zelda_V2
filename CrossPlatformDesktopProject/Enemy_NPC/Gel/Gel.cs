﻿using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Gel : AbstractNPC
    {
        private int movementTimer = 0;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.EnemyGround;

        public Gel()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGel();
            Position = Constant.EnemyStartPosition;

            DamageAmount = EnemyConstants.GelDamageAmount;
            MaxHP = EnemyConstants.GelHP;
            CurrentHP = MaxHP;

            Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * EnemyConstants.GelSpeed;
            if (Velocity.X.Equals(0f))
            {
                Velocity = Vector2.UnitY * Constant.RNG.Next(-1, 2) * EnemyConstants.GelSpeed;
            }
        }

        public override void Update()
        {
            MoveGel();
            base.Update();
        }

        private void MoveGel()
        {
            if(movementTimer == EnemyConstants.GelMovementTimer)
            {
                Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * EnemyConstants.GelSpeed;
                if (Velocity.X.Equals(0f))
                {
                    Velocity = Vector2.UnitY * Constant.RNG.Next(-1, 2) * EnemyConstants.GelSpeed;
                }
                movementTimer = 0;
            }
            if (HasHitWall)
            {
                HasHitWall = false;
                TurnRight(EnemyConstants.GelSpeed);
            }
            Position += Velocity;
            movementTimer++;
        }
    }
}
