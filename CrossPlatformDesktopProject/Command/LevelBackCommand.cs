namespace Sprint2
{
    public class LevelBackCommand : ICommand
    {
        private GameObjects objects;

        public LevelBackCommand(Game1 game)
        {
            objects = new GameObjects(game);
        }

        public void Execute()
        {
            if (objects.LevelListPosition > 0)
            {
                objects.LevelListPosition--;
            }
        }
    }
}
