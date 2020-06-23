namespace Sprint2
{
    public class UseItem6Command : ICommand
    {
        private Game1 game;

        public UseItem6Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.Item = new UsableBow(game.Link, Constant.ArrowType.wooden);
            game.Link.UseItem();
        }
    }
}