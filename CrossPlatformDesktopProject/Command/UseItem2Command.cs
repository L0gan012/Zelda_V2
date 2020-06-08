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
            this.game.Link.Item = this.game.ListOfItems[2];
            this.game.Link.UseItem();
        }
    }
}