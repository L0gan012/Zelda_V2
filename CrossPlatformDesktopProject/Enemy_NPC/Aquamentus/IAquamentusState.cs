using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IAquamentusState
    {
        void MouthOpen();
        void MouthClose();
        void Update();
        void Draw(SpriteBatch spriteBatch, Color color, Vector2 location);
    }
}
