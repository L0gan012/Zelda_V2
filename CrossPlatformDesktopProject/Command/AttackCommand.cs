namespace Sprint2
{
    public class AttackCommand : ICommand
    {

        public AttackCommand()
        {
        }

        public void Execute()
        {
            Game1.Instance.Link.PrimaryItem = new UsableWoodenSword(Game1.Instance.Link);
            Game1.Instance.Link.Attack();
        }
    }
}