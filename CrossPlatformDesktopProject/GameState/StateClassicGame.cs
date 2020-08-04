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

            ToolsXML toolsXml = new ToolsXML();
            toolsXml.InitializeGameObjects();
            GameObjects.Instance.loadObjs();
            toolsXml.SetStageXmlDocument();

            Game.Link = new Link();
            Game.miniHUD = new MiniHUD(Game.Link);
            Game.PauseHUD = new PauseHUD(Game.Link, Game.miniHUD);

            Game.miniHUD.LoadHUDTextures();
            Game.PauseHUD.LoadHUDTextures();
            Game.CollisionDetector = new CollisionDetector();
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

            if (Game.currentScore > Game.highestScore)
            {
                Game.highestScore = Game.currentScore;
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

        public void ShowScore()
        {
            Game.State = new StateScoreboard(this, Game.highestScore, Game.currentScore);
        }

        public void Update(IGameObject obj)
        {
        }
    }
}
