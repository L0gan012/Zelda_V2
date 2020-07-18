using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StatePaused : IGameState
    {
        public Game1 Game { get; set; }
        private SpriteBatch spriteBatch;
        private IGameState state;

        public StatePaused(IGameState state)
        {
            Game = Game1.Instance;
            this.state = state;
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
        }

        public void Update()
        {
            foreach (IController controller in Game.controllers)
            {
                controller.Update();
            }
        }

        public void Draw(SpriteBatch sb)
        {
            state.Draw(sb);
        }

        public void Pause()
        {
        }

        public void UnPause()
        {
            Game.state = state;
        }
    }
}
