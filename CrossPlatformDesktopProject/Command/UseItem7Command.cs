namespace Sprint2.Controller
{
    internal class UseItem7Command : ICommand
    {
        private Game1 game;

        public UseItem7Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.Item = new UsableBow(game.Link, UsableBow.ArrowType.silver);
            game.Link.UseItem();
        }
    }
}