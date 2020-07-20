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

            MiniHUD.MiniHUDPosition = new Vector2(0, Constant.PauseHUDHeight);
        }

        public void Update()
        {
            foreach (IController controller in Game.controllers)
            {
                controller.Update();
            }
            Game.pauseHUD.Update();
        }

        public void Draw(SpriteBatch sb)
        {
            /*ISprite inventory = HUDSpriteFactory.Instance.CreateHUDInventory();
            inventory.Draw(spriteBatch, color, Constant.InventoryPanelLocation);

            ISprite dungeon = HUDSpriteFactory.Instance.CreateHUDDungeon();
            dungeon.Draw(spriteBatch, color, Constant.DungeonPanelLocation);

            ISprite HUD = HUDSpriteFactory.Instance.CreateHUDHud();
            HUD.Draw(spriteBatch, color, Constant.HUDPanelLocation);*/

            Game.pauseHUD.Draw(sb);
        }

        public void Pause()
        {
        }

        public void UnPause()
        {
            MiniHUD.MiniHUDPosition = new Vector2();
            Game.state = state;
        }

        public void Update(IGameObject obj)
        {

        }
    }
}
