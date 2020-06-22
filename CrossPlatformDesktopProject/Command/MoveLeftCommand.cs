namespace Sprint2
{
    public class MoveLeftCommand : ICommand
    {
        private Game1 game;

        public MoveLeftCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.MoveLeft();
        }
    }
}
