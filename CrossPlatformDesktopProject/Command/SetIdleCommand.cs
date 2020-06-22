namespace Sprint2
{
    public class SetIdleCommand : ICommand
    {
        private Game1 game;

        public SetIdleCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.SetIdle();
        }
    }
}