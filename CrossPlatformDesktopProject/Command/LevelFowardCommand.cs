using System;

namespace Sprint2
{
    public class LevelFowardCommand : ICommand
    {

        private GameObjects roomChange;
        public LevelFowardCommand()
        {
            roomChange = new GameObjects();
        }

        public void Execute()
        {
            if (GameObjects.LevelListPosition < roomChange.DungeonRoomCount)
            {
                GameObjects.LevelListPosition++;
                roomChange.UpdateRoom();

            }
        }
    }
}
