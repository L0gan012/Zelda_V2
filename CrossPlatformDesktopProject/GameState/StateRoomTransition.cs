using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateRoomTransition : IGameState
    {
        public List<IController> controllers;
        private IGameState state;
        private Game1 Game;

        public StateRoomTransition(IGameState state)
        {
            Game = Game1.Instance;
            this.state = state;
            controllers = new List<IController>();
        }

        public void Update(IGameObject obj)
        {
            GameObjects.Instance.currentRoom = new Room();
            switch (obj.GameObjectType)
            {
                case Enumerations.GameObjectType.DoorTriggerLeft:
                    GameObjects.Instance.LevelListPosition -= 1;
                    GameObjects.Instance.UpdateRoom();
                    Game1.Instance.Link.Position = new Vector2(671, 400);
                    break;
                case Enumerations.GameObjectType.DoorTriggerRight:
                    GameObjects.Instance.LevelListPosition += 1;
                    GameObjects.Instance.UpdateRoom();
                    Game1.Instance.Link.Position = new Vector2(97, 400);
                    break;
                case Enumerations.GameObjectType.DoorTriggerDown:
                    GameObjects.Instance.LevelListPosition += Constant.DungeonGridWidth;
                    GameObjects.Instance.UpdateRoom();
                    Game1.Instance.Link.Position = new Vector2(360, 265);
                    break;
                case Enumerations.GameObjectType.DoorTriggerUp:
                    GameObjects.Instance.LevelListPosition -= Constant.DungeonGridWidth;
                    GameObjects.Instance.UpdateRoom();
                    Game1.Instance.Link.Position = new Vector2(360, 550);
                    break;
                case Enumerations.GameObjectType.StairsTrigger:
                    GameObjects.Instance.LevelListPosition = 0;
                    GameObjects.Instance.UpdateRoom();
                    Game1.Instance.Link.Position = new Vector2(144, 400);
                    break;
                case Enumerations.GameObjectType.DoorTriggerExitTreasureRoom:
                    GameObjects.Instance.LevelListPosition = 1;
                    GameObjects.Instance.UpdateRoom();
                    Game1.Instance.Link.Position = new Vector2(320, 300);
                    break;
                default:
                    break;
            }

         
        }

        public void Draw(SpriteBatch sb)
        {
            state.Draw(sb);
        }

        public void Pause()
        {

        }

        public void UnPause()
        {
        }

        public void Update()
        {
            
        }
    }
}
