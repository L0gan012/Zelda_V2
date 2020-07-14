namespace Sprint2
{
    public class LevelBackCommand : ICommand
    {

        private GameObjects roomChange;

        public LevelBackCommand()
        {
            roomChange = new GameObjects();

        }

        public void Execute()
        {
            if (Game1.Instance.state is StateInLevel)
            {
                if (GameObjects.LevelListPosition > 0)
                {
                    GameObjects.LevelListPosition--;
                    roomChange.UpdateRoom();
                }
            }
        }
    }
}
