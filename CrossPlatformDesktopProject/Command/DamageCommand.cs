namespace Sprint2
{
    public class DamageCommand : ICommand
    {
 
        public DamageCommand()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.DamagePlayer(1);
        }
    }
}
