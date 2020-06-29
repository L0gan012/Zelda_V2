namespace Sprint2
{
    public class LevelBackCommand : ICommand
    {
       

        public LevelBackCommand()
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
