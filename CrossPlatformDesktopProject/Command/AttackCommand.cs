namespace Sprint2
{
    public class AttackCommand : ICommand
    {

        public AttackCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.state is StateInLevel)
            {
                Game1.Instance.Link.PrimaryItem = new UsableWoodenSword(Game1.Instance.Link);
                Game1.Instance.Link.Attack();
            }
                
        }
    }
}