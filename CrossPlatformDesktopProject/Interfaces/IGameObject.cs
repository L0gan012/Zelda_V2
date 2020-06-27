using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IGameObject
    {
        Vector2 Position { get; set; }

        Vector2 Center { get; }

        Color Color { get; set; }

        Rectangle Rectangle { get; }

        ISprite Sprite { get; set; }

        bool IsDestructable { get; set; }

        bool Knockback { get; set; }

        Vector2 CollisionLocation { get; set; }

        Vector2 Velocity { get; set; }

        Enumerations.GameObjectType GameObjectType { get; set; }

        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
