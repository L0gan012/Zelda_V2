namespace Sprint2
{
    public class ItemFowardCommand : ICommand
    {
        private Game1 game;

        public ItemFowardCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (game.ItemListPosition < game.ListOfItems.Count - 1) 
            { 
                game.ItemListPosition++; 
            }
        }
    }
}