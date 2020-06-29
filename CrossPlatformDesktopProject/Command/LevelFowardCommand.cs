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
            if (GameObjects.LevelListPosition < GameObjects.LevelLoader.rooms.Count - 1)
            {
                GameObjects.LevelListPosition++;

            }
        }
    }
}
