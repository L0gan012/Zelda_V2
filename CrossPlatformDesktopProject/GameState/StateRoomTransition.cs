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
            Game1.Instance.objects.currentRoom = new Room();
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
                    Game1.Instance.objects.LevelListPosition = 0;
                    break;
                default:
                    break;
            }

            //Need the current room that is listed and need to find and store the next room
          //  Game1.Instance.objects.currentRoom.StoreRoom(Game1.Instance.objects.LevelListPosition);
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
