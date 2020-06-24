using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IDodongoState 
    {
        void BePuffed();

        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}