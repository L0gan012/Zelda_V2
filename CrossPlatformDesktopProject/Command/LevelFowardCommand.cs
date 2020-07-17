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
            if (Game1.Instance.state is StateInLevel)
            {
                if (GameObjects.Instance.LevelListPosition < GameObjects.Instance.DungeonRoomCount)
                {
                    GameObjects.Instance.LevelListPosition++;
                    GameObjects.Instance.UpdateRoom();
                }
            }
        }
    }
}
