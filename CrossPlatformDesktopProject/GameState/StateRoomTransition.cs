using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateRoomTransition : IGameState
    {
        public List<IController> controllers;
        public Game1 Game { get; set; }
        private IGameState state;

        public StateRoomTransition(Game1 game, IGameState state)
        {
            Game = game;
            this.state = state;
            controllers = new List<IController>();
        }

        public void Update()
        {
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
        }
    }
}
