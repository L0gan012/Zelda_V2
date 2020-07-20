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
        

        public StateRoomTransition(IGameState state)
        {
            
            this.state = state;
            controllers = new List<IController>();
        }

        public void Update(IGameObject obj)
        {
            Game1.Instance.objects.currentRoom = new Room();
            switch (obj.GameObjectType)
            {
                case Enumerations.GameObjectType.DoorTriggerLeft:
                    Console.WriteLine(Game1.Instance.objects.LevelListPosition);
                    Game1.Instance.objects.LevelListPosition -= Constant.DungeonGridWidth;
                    Game1.Instance.Link.Position = new Vector2(100, 20);
                    break;
                case Enumerations.GameObjectType.DoorTriggerRight:
                    Game1.Instance.objects.LevelListPosition += Constant.DungeonGridWidth;
                    break;
                case Enumerations.GameObjectType.DoorTriggerDown:
                    Game1.Instance.objects.LevelListPosition -= Constant.DungeonGridHeight;
                    break;
                case Enumerations.GameObjectType.DoorTriggerUp:
                    Game1.Instance.objects.LevelListPosition += Constant.DungeonGridWidth;
                    break;
                case Enumerations.GameObjectType.StairsTrigger:
                    Game1.Instance.objects.LevelListPosition = 0;
                    break;
                default:
                    break;
            }
            
            //Need the current room that is listed and need to find and store the next room
            Game1.Instance.objects.currentRoom.StoreRoom(Game1.Instance.objects.LevelListPosition);
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
