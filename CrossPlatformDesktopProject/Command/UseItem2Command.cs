namespace Sprint2
{
    public class UseItem2Command : ICommand
    {
        private Game1 game;

        public UseItem2Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.SecondaryItem = new UsableBlueCandle(game.Link);
            game.Link.UseItem();
        }
    }
}