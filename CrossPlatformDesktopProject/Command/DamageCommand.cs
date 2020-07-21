namespace Sprint2
{
    public class DamageCommand : ICommand
    {
 
        public DamageCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                Game1.Instance.Link.DamagePlayer(1);
            }
        }
    }
}
