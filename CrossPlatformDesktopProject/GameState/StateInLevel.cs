using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateInLevel : IGameState
    {
        public List<IController> controllers;
        public Game1 Game { get; set; }
        private int counter;

        public StateInLevel(Game1 game)
        {
            Game = game;
            Game.state = this;
        }

        public void Update()
        {
        }
        
        public void Draw(SpriteBatch sb)
        {

        }

        public void Pause()
        {
            Game.state = new StatePaused(Game, this);
        }

        public void UnPause()
        {

        }
    }
}
