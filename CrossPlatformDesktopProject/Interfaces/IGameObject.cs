using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static Sprint2.Enumerations;

namespace Sprint2
{
    public interface IGameObject
    {
        Vector2 Position { get; set; }

        void Update();

        void Draw(SpriteBatch spriteBatch);

        Rectangle GetRectangle();

        GameObjectType GameObjectType { get; set; }


    }
}
