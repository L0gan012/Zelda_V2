namespace Sprint2
{
    public class BlockBackCommand : ICommand
    {
        private Game1 game;

        public BlockBackCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (game.BlockListPosition > 0)
            {
                game.BlockListPosition--;
            }
        }
    }
}
