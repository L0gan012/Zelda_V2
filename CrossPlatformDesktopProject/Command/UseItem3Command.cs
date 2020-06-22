namespace Sprint2
{
    public class UseItem3Command : ICommand
    {
        private Game1 game;

        public UseItem3Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.Item = new UsableLadder(game.Link);
            game.Link.UseItem();
        }
    }
}