namespace Sprint2
{
    public class LevelBackCommand : ICommand
    {
       

        public LevelBackCommand(Game1 game)
        {

        }

        public void Execute()
        {
            if (GameObjects.LevelListPosition > 0)
            {
                GameObjects.LevelListPosition--;
            }
        }
    }
}
