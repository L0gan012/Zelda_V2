using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IGameState
    {
        Game1 Game { get; set; }

        void Update();

        void Draw(SpriteBatch sb);

        void Pause();

        void UnPause();
    }
}
