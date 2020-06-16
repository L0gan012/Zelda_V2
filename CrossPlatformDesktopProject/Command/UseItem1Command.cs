namespace Sprint2.Controller
{
    internal class UseItem1Command : ICommand
    {
        private Game1 game;

        public UseItem1Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            this.game.Link.Item = new UsableItemCandle(this.game.Link);
            this.game.Link.UseItem();
        }
    }
}