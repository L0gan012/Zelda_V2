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
            message = "Change keyboard controls";
        }

        public override void Select()
        {
            currentState = State.Selected;
            message = "Press the key you \nwould like to change";
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
                                message = "Old key - " + oldKey + " \nPress an unused key to replace";
                            }
                            break;
                        case State.listeningForNewKey:
                            Keys newKey = ((KeyboardController)controller).NewPressedKey;
                            if(((KeyboardController)controller).TrySwitchKey(oldKey, newKey))
                            {
                                currentState = State.NotSelected;
                                message = oldKey + " replaced with " + newKey + ", \nSelect to change keyboard controls";
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
