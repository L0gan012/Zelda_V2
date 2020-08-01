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
            /*ISprite inventory = HUDSpriteFactory.Instance.CreateHUDInventory();
            inventory.Draw(spriteBatch, color, Constant.InventoryPanelLocation);

            ISprite dungeon = HUDSpriteFactory.Instance.CreateHUDDungeon();
            dungeon.Draw(spriteBatch, color, Constant.DungeonPanelLocation);

            ISprite HUD = HUDSpriteFactory.Instance.CreateHUDHud();
            HUD.Draw(spriteBatch, color, Constant.HUDPanelLocation);*/

            Game.PauseHUD.Draw(sb);
        }

        public void Pause()
        {
            GameObjects.Instance.currentRoom.UpdateSavedStateXML();
            ToolsXML toolsXml = new ToolsXML();
            toolsXml.SaveUpdatedRoomXml();
        }

        public void UnPause()
        {
          //  GameObjects.Instance.currentRoom.UpdateSavedStateXML();
            ToolsXML toolsXml = new ToolsXML();
            toolsXml.SetStageXmlDocument();
            MiniHUD.MiniHUDPosition = new Vector2();
            Game.State = state;
        }

        public void Update(IGameObject obj)
        {

        }
    }
}
