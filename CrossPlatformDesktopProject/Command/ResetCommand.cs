namespace Sprint2
{
    public class ResetCommand : ICommand
    {
        private Game1 game;

        public ResetCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link = new Link(game);
        }
    }
}
