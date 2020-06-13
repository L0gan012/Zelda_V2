using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IProjectile
    {
        //Updates the item
        void Update();

        //Draws the item
        void Draw(SpriteBatch spriteBatch, Vector2 position);
    }
}
