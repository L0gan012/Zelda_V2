using System;

namespace Sprint2
{
    public class LevelFowardCommand : ICommand
    {
        public string Description { get; }

        public LevelFowardCommand()
        {
            Description = StringConstants.LevelForwardDescription;
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
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
