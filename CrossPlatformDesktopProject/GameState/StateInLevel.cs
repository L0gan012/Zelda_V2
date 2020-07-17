﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateInLevel : IGameState
    {
        public Game1 Game { get; set; }
        private SpriteBatch spriteBatch;
        public StateInLevel(Game1 game)
        {
            Game = game;
            Game.state = this;
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
        }

        public void Update()
        {   
            foreach (IController controller in Game.controllers)
            {
                controller.Update();
            }
            Game.Link.Update();
            Game.objects.Update();
            Game.HUD.Update();

            Game.playerObjectList = new List<IPlayer>();

            Game.playerObjectList.Add(Game.Link);

            Game.collisionDetector.Update(Game.playerObjectList,
                Room.CurrentRoomChars,
                Room.CurrentRoomProjectiles,
                Room.CurrentRoomBlocks,
                Room.CurrentRoomItems,
                Room.CurrentRoomUsableItems);
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Game.GraphicsDevice.Clear(Color.LightGray);
            Game.objects.Draw(spriteBatch);
            Game.Link.Draw(spriteBatch);
            Game.HUD.Draw(spriteBatch);
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
