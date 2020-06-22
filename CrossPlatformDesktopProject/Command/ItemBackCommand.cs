namespace Sprint2
{
    public class ItemBackCommand : ICommand
    {
        private Game1 game;

        public ItemBackCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (game.ItemListPosition > 0) 
            { 
                game.ItemListPosition--; 
            }
        }
    }
}