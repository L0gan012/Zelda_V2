namespace Sprint2.Controller
{
    internal class UseItem3Command : ICommand
    {
        private Game1 game;

        public UseItem3Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            this.game.Link.UseItem();
        }
    }
}