using System;

namespace Sprint2
{
    public class LevelFowardCommand : ICommand
    {

        public LevelFowardCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateInLevel)
            {
                if (GameObjects.Instance.LevelListPosition < GameObjects.Instance.DungeonRoomCount - 1)
                {
                    GameObjects.Instance.LevelListPosition++;
                    GameObjects.Instance.UpdateRoom();
                }
            }
        }
    }
}
