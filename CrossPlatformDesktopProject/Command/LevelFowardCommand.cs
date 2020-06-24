namespace Sprint2
{
    public class LevelFowardCommand : ICommand
    {
        private GameObjects objects;

        public LevelFowardCommand(Game1 game)
        {
            objects = new GameObjects(game);
        }

        public void Execute()
        {
            if (objects.LevelListPosition < objects.LevelListPosition - 1)
            {
                objects.LevelListPosition++;
            }
        }
    }
}
