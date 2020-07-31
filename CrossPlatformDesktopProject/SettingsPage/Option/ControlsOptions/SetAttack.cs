using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class SetAttack : AbstractOption
    {
        private string Message;
        private bool isSelected;

        public SetAttack(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
            Message = "Change Attack Key";
        }

        public override void Select()
        {
            isSelected = true;
            Message = "Press any keyboard key to set Attack";
        }

        public override void Update()
        {
            Keys[] currentPressedKeys = Keyboard.GetState().GetPressedKeys();
            if (isSelected && currentPressedKeys.Length > 0)
            {
                Keys newKey = currentPressedKeys[0];
                List<Keys> toChange = new List<Keys>();

                foreach (IController controller in Game1.Instance.Controllers)
                {
                    if (controller is KeyboardController)
                    {
                        Dictionary<Keys, ICommand> commands = ((KeyboardController)controller).CommandDictionary;
                        foreach (KeyValuePair<Keys, ICommand> pair in commands)
                        {
                            if(pair.Value is AttackCommand)
                            {
                                toChange.Add(pair.Key);
                                isSelected = false;
                                Message = "Change Attack Key";
                            }
                        }

                        foreach(Keys keyToChange in toChange)
                        {
                            commands.Remove(keyToChange);
                            commands.Add(newKey, new AttackCommand());
                        }
                    }
                }
            }
        }

        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.DrawString(spriteFont, Message, Position, Color);
        }
    }
}
