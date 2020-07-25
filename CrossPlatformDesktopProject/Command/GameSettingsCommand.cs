﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    class GameSettingsCommand : ICommand
    {
        private List<Vector2> selectionPosition;
        private int listCounter;
        public GameSettingsCommand()
        {
            selectionPosition = new List<Vector2>();
            selectionPosition.Add(new Vector2(400, 200));
            selectionPosition.Add(new Vector2(400, 300));
            selectionPosition.Add(new Vector2(400, 100));
            listCounter = 0;
        }

        public void Execute()
        {

            //Changes state to settings state if game is in play
            if (Game1.Instance.State is StateClassicGame && Keyboard.GetState().IsKeyDown(Keys.B))
            {
                Game1.Instance.State = new StateSetting();
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Space, new GameSettingsCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Tab, new GameSettingsCommand());



            } else if (Keyboard.GetState().IsKeyDown(Keys.B))
            {
                Game1.Instance.State = new StateOptionSelection(Game1.Instance.State);
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Space, new GameSelectionCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Tab, new GameSelectionCommand());
            }



            //Returns to game from settings 
            if (Keyboard.GetState().IsKeyDown(Keys.F))
            {
                Game1.Instance.State = new StateClassicGame();
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Space, new NullCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Tab, new NullCommand());
            }


            //Selects Music
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && StateSetting.vector.Y == 200)
            {
                Game1.Instance.State = new StateMusicSelection();
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Space, new GameMusicSelectionCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Tab, new GameMusicSelectionCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.B, new GameMusicSelectionCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.M, new GameMusicSelectionCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.PageUp, new GameMusicSelectionCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.PageDown, new GameMusicSelectionCommand());

            }



            //Changes selection for game wanted
            if (Keyboard.GetState().IsKeyDown(Keys.Tab))
            {
                if(listCounter == selectionPosition.Count) {listCounter = 0;}
                StateSetting.vector = selectionPosition[listCounter];
                listCounter++;
            }



        }
    }
}