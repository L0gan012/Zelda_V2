namespace Sprint2
{
    public class BlockFowardCommand : ICommand
    {
        private Game1 game;

        public BlockFowardCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (game.BlockListPosition < game.ListOfBlocks.Count - 1)
            {
                game.BlockListPosition++;
            }
        }
    }
}
