﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static Sprint2.Enumerations;

namespace Sprint2.Projectile
{
    public class ProjectileWoodenSwordDown : IProjectile
    {
        GameObjectType gameObjectType { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Heading { get; set; }
        public bool IsVsEnemy { get; set; }
        public bool IsVsPlayer { get; set; }
        public bool IsReturnToSender { get; }
        public bool IsLimitToOne { get; }
        public bool IsAbleToBreakWalls { get; }
        public int ParalysisDuration { get; }
        public int Damage { get; set; }
        public int Velocity { get; set; }
        public int Knockback { get; }


        private ISprite projectileSprite;
        private Color color;



        public ProjectileWoodenSwordDown(Vector2 projectileSourcePosition)
        {
            gameObjectType = GameObjectType.ProjectileVsEnemy;
            Vector2 weaponOffset = new Vector2(3, 16);
            projectileSprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenSwordDown();
            Position = new Vector2(projectileSourcePosition.X + weaponOffset.X, projectileSourcePosition.Y + weaponOffset.Y);
            color = Color.White;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            projectileSprite.Draw(spriteBatch, color, Position);
        }


        public void Update()
        {
            Position = new Vector2(Position.X, Position.Y + 1 * Constant.SwordBeamSpeed);
            projectileSprite.Update();
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle((int)Position.X, (int)Position.Y, projectileSprite.GetWidth(), projectileSprite.GetHeight());
        }
    }
}