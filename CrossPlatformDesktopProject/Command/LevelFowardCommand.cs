using System;

namespace Sprint2
{
    public class LevelFowardCommand : ICommand
    {

        public LevelFowardCommand(Game1 game)
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
