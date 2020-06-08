namespace Sprint2.Controller
{
    internal class UseItem0Command : ICommand
    {
        private Game1 game;

        public UseItem0Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            this.game.Link.Item = this.game.ListOfItems[0];
            this.game.Link.UseItem();
        }
    }
}