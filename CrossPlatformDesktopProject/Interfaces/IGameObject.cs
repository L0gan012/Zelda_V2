using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static Sprint2.Enumerations;

namespace Sprint2
{
    public interface IGameObject
    {
        Vector2 Position { get; set; }

        Vector2 Center { get; }

        Color Color { get; set; }

        Rectangle Rectangle { get; }

        ISprite Sprite { get; set; }

        GameObjectType GameObjectType { get; set; }

        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
