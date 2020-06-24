namespace Sprint2
{
    public class UseItem7Command : ICommand
    {
        private Game1 game;

        public UseItem7Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.SecondaryItem = new UsableBow(game.Link, Constant.ArrowType.silver);
            game.Link.UseItem();
        }
    }
}