namespace Sprint2.Command
{
    class ExitCommand : ICommand
    {
        private Game1 game;

        public ExitCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            this.game.Exit();
        }
    }
}
