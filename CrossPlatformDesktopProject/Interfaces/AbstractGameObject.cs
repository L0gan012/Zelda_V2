﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Sprint2
{
    public abstract class AbstractGameObject : IGameObject
    {
        public virtual ISprite Sprite { get; set; }
        public Vector2 Position { get; set; }
        public Color Color { get; set; } = Color.White;

        public virtual Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)Sprite.GetHeight());
            }
        }

        public Vector2 Center
        {
            get
            {
                float x = Position.X + Sprite.GetWidth() / 2.0f;
                float y = Position.Y + Sprite.GetHeight() / 2.0f;
                return new Vector2(x, y);
            }
        }

        public bool IsDestructable { get; set; } = false;
        public bool Knockback { get; set; } = false;
        public Vector2 CollisionLocation { get; set; }
        public Vector2 Velocity { get; set; }

        public abstract Enumerations.GameObjectType GameObjectType { get; set; }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (Sprite != null)
            {
                Sprite.Draw(spriteBatch, Color, Position);
            }
        }

        public virtual void Update()
        {
            if (Sprite != null)
            {
                Sprite.Update();
            }
        }
    }
}
