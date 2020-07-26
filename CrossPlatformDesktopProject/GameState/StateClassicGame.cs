using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateClassicGame : IGameState
    {
        public Game1 Game { get; set; }
        public StateClassicGame()
        {
            Game = Game1.Instance;
            Game.State = this;
            SoundManager.Instance.PlayDefaultMusic();
        }

        public void Update()
        {
            foreach (IController controller in Game.Controllers)
            {
                controller.Update();
            }
            Game.Link.Update();
            GameObjects.Instance.Update();
            Game.miniHUD.Update();

            Game.PlayerObjectList = new List<IPlayer>();

            Game.PlayerObjectList.Add(Game.Link);

            Game.CollisionDetector.Update(Game.PlayerObjectList,
                Room.CurrentRoomChars,
                Room.CurrentRoomProjectiles,
                Room.CurrentRoomBlocks,
                Room.CurrentRoomItems,
                Room.CurrentRoomUsableItems,
                Room.CurrentRoomDoorTriggers);

            if (Game.Link.HP == 0)
            {
                Game.State = new StateGameOver(this);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
            Game.GraphicsDevice.Clear(Color.LightGray);
            GameObjects.Instance.Draw(spriteBatch);
            Game.Link.Draw(spriteBatch);
            Game.miniHUD.Draw(spriteBatch);
        }

        public void Pause()
        {
            Game.State = new StatePaused(this);
        }

        public void UnPause()
        {

        }

        public void Update(IGameObject obj)
        {
        }
    }
}
