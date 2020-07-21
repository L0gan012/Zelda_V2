namespace Sprint2
{
    public class ResetCommand : ICommand
    {

        public ResetCommand()
        {

        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.Link = new Link();
                GameObjects.Instance.LevelListPosition = 32;
                GameObjects.Instance.UpdateRoom();
            }
        }
    }
}
