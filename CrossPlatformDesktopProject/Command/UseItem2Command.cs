namespace Sprint2.Controller
{
    internal class UseItem2Command : ICommand
    {
        private Game1 game;

        public UseItem2Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            this.game.Link.Item = new UsableBlueCandle(this.game.Link);
            this.game.Link.UseItem();
        }
    }
}