namespace Sprint2
{
    public class AttackCommand : ICommand
    {
        private Game1 game;

        public AttackCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.Attack();
        }
    }
}