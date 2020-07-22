namespace Sprint2
{
    public class BackCommand : ICommand
    {

        public BackCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.Link.PrimaryItem = new UsableWoodenSword(Game1.Instance.Link);
                Game1.Instance.Link.Attack();
            }
                
        }
    }
}