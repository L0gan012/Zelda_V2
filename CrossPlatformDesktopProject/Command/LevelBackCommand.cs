namespace Sprint2
{
    public class LevelBackCommand : ICommand
    {
        public string Description { get; }

        public LevelBackCommand()
        {
            Description = StringConstants.LevelBackDescription;
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
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
