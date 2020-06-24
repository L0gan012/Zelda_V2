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
            game.Link.SecondaryItem = new UsableBow(game.Link, Enumerations.ArrowType.wooden);
            game.Link.UseItem();
        }
    }
}