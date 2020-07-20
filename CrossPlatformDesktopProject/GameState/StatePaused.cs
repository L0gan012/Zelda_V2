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
            ISprite inventory = HUDSpriteFactory.Instance.CreateHUDInventory();
            inventory.Draw(spriteBatch, color, Constant.InventoryPanelLocation);

            ISprite dungeon = HUDSpriteFactory.Instance.CreateHUDDungeon();
            dungeon.Draw(spriteBatch, color, Constant.DungeonPanelLocation);

            ISprite HUD = HUDSpriteFactory.Instance.CreateHUDHud();
            HUD.Draw(spriteBatch, color, Constant.HUDPanelLocation);
        }

        public void Pause()
        {
        }

        public void UnPause()
        {
            Game.state = state;
        }

        public void Update(IGameObject obj)
        {

        }
    }
}
