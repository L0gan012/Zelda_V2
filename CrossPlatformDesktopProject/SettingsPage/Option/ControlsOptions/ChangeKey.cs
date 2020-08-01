using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class ChangeKey : AbstractOption
    {
        private string message;
        private enum State { NotSelected, Selected, listeningForOldKey, listeningForNewKey };
        private State currentState;
        private Keys oldKey;

        public ChangeKey(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
            currentState = State.NotSelected;
            message = StringConstants.ChangeKeyRegularMessage;
        }

        public override void Select()
        {
            currentState = State.Selected;
            message = StringConstants.ChangeKeySelectedMessage;
        }

        public override void Update()
        {
            foreach (IController controller in Game1.Instance.Controllers)
            {
                if(controller is KeyboardController)
                {
                    switch (currentState)
                    {
                        case State.Selected:
                            currentState = State.listeningForOldKey;
                            break;
                        case State.listeningForOldKey:
                            oldKey = ((KeyboardController)controller).NewPressedKey;
                            Console.WriteLine(oldKey);
                            if(oldKey != Keys.None)
                            {
                                currentState = State.listeningForNewKey;
                                message = StringConstants.ChangeKeyOldKey + oldKey + StringConstants.ChangeKeyReplaceKeyMessage;
                            }
                            break;
                        case State.listeningForNewKey:
                            Keys newKey = ((KeyboardController)controller).NewPressedKey;
                            if(((KeyboardController)controller).TrySwitchKey(oldKey, newKey))
                            {
                                currentState = State.NotSelected;
                                message = oldKey + StringConstants.ChangeKeyReplacedWith + newKey + StringConstants.ChangeKeyGoAgainMessage;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.DrawString(spriteFont, message, Position, Color);
        }

    }
}
