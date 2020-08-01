namespace Sprint2
{
    public class ResetCommand : ICommand
    {
        public string Description { get; }

        public ResetCommand()
        {
            Description = StringConstants.ResetDescription;
        }

        public void Execute()
        {
            Game1.Instance.State = new StateSettings(Game1.Instance.State);
            Game1.Instance.Link = new Link();
            GameObjects.Instance.LevelListPosition = 32;
            GameObjects.Instance.UpdateRoom();
        }
    }
}
