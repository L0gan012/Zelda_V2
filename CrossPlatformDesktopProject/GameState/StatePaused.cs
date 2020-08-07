using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StatePaused : IGameState
    {
        public Game1 Game { get; set; }
        private SpriteBatch spriteBatch;
        private IGameState state;
        private Color color;

        public StatePaused(IGameState state)
        {
            Game = Game1.Instance;
            this.state = state;
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            color = Color.White;
            MiniHUD.MiniHUDPosition = new Vector2(0, HUDConstants.PauseHUDHeight * Constant.DisplayScaleY);
        }

        public void Update()
        {
            foreach (IController controller in Game.Controllers)
            {
                controller.Update();
            }
            Game.PauseHUD.Update();
        }

        public void Draw(SpriteBatch sb)
        {
            Game.PauseHUD.Draw(sb);
        }

        public void Pause()
        {

        }

        public void UnPause()
        {
            MiniHUD.MiniHUDPosition = new Vector2();
            Game.State = state;
        }

        public void Update(IGameObject obj)
        {

        }
    }
}
