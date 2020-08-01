using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> CommandDictionary { get; set; }
        private Keys prev;
        private Keys[] currentPressedKeys;
        private Keys[] newPressedKeys;
        private Keys[] prevPressedKeys;

        public Keys NewPressedKey { get; private set; }

        public KeyboardController()
        {
            CommandDictionary = new Dictionary<Keys, ICommand>();
            prev = Keys.None;
            
            prevPressedKeys = new Keys[0] { };
        }

        public void RegisterCommand()
        {
            CommandDictionary.Add(Keys.Q, new ExitCommand());
            CommandDictionary.Add(Keys.R, new ResetCommand());

            CommandDictionary.Add(Keys.None, new SetIdleCommand());

            CommandDictionary.Add(Keys.Up, new MoveUpCommand());
            CommandDictionary.Add(Keys.Down, new MoveDownCommand());
            CommandDictionary.Add(Keys.Left, new MoveLeftCommand());
            CommandDictionary.Add(Keys.Right, new MoveRightCommand());

            CommandDictionary.Add(Keys.W, new MoveUpCommand());
            CommandDictionary.Add(Keys.S, new MoveDownCommand());
            CommandDictionary.Add(Keys.A, new MoveLeftCommand());
            CommandDictionary.Add(Keys.D, new MoveRightCommand());

            CommandDictionary.Add(Keys.Z, new UseSecondaryItemCommand());

            CommandDictionary.Add(Keys.X, new AttackCommand());
            CommandDictionary.Add(Keys.N, new AttackCommand());

            CommandDictionary.Add(Keys.I, new LevelFowardCommand());
            CommandDictionary.Add(Keys.U, new LevelBackCommand());

            CommandDictionary.Add(Keys.Enter, new PauseCommand());
            CommandDictionary.Add(Keys.C, new SelectItemForwardCommand());

            CommandDictionary.Add(Keys.M, new MusicVolumeCommand());
            CommandDictionary.Add(Keys.PageUp, new MusicVolumeCommand());
            CommandDictionary.Add(Keys.PageDown, new MusicVolumeCommand());

            CommandDictionary.Add(Keys.P, new OpenSettingsFromPausedCommand());
            CommandDictionary.Add(Keys.Space, new SettingsSelectCommand());
            CommandDictionary.Add(Keys.Tab, new SettingsCycleOptionCommand());
            CommandDictionary.Add(Keys.B, new GoBackCommand());
            CommandDictionary.Add(Keys.F, new OpenScoreboardCommand());

            //Debugging Collision
            CommandDictionary.Add(Keys.F1, new DebugDrawHitBoxesCommand());
        }


        public void UpdateCommand(Keys key, ICommand commandClass)
        {
            if (CommandDictionary.ContainsKey(key)) { CommandDictionary[key] = commandClass; }
        }

        public bool TrySwitchKey(Keys oldKey, Keys newKey)
        {
            bool canChange = oldKey != prev && CommandDictionary.ContainsKey(oldKey) && !CommandDictionary.ContainsKey(newKey);
            if (canChange)
            {
                ICommand command = CommandDictionary[oldKey];
                CommandDictionary.Remove(oldKey);
                CommandDictionary.Add(newKey, command);
            }
            return canChange;
        }

        public void Update()
        {
            currentPressedKeys = Keyboard.GetState().GetPressedKeys();
            newPressedKeys = currentPressedKeys.Except(prevPressedKeys).ToArray();

            Keys toExecute = prev;

            if (currentPressedKeys.Length == 0)
            {
                toExecute = Keys.None;
            }
            else if (newPressedKeys.Length > 0)
            {
                toExecute = newPressedKeys[0];
            }

            if (toExecute != prev && CommandDictionary.ContainsKey(toExecute))
            {
                CommandDictionary[toExecute].Execute();
            }

            NewPressedKey = Keys.None;
            if (toExecute != prev)
            {
                NewPressedKey = toExecute;
            }

            prev = toExecute;
            prevPressedKeys = currentPressedKeys;
        }

        public void DeregisterCommands()
        {
        }

        public void DrawKeysAndDescriptions(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            Vector2 Position = SettingsConstants.Option1Position;
            foreach(KeyValuePair<Keys, ICommand> pair in CommandDictionary)
            {
                String text = pair.Key + " - " + pair.Value.Description;
                spriteBatch.DrawString(spriteFont, text, Position, Color.White);
                Position.Y += SettingsConstants.OptionHeight;
            }
        }
    }
}
