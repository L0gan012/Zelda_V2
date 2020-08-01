namespace Sprint2
{
    public class AttackCommand : ICommand
    {
        public string Description { get; }

        public AttackCommand()
        {
            Description = StringConstants.AttackDescription;
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