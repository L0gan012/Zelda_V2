using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IGameState
    {

        void Update();

        //void Update(IGameObject obj);

        void Draw(SpriteBatch sb);

        void Pause();

        void UnPause();
    }
}
