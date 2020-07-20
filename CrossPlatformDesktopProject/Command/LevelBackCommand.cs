namespace Sprint2
{
    public class LevelBackCommand : ICommand
    {

        private GameObjects roomChange;

        public LevelBackCommand()
        {

        }

        public void Execute()
        {
            if (Game1.Instance.State is StateInLevel)
            {
                if (GameObjects.Instance.LevelListPosition > 0)
                {
                    GameObjects.Instance.LevelListPosition--;
                    GameObjects.Instance.UpdateRoom();
                }
            }
        }
    }
}
