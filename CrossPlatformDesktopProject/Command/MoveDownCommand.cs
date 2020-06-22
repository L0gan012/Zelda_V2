namespace Sprint2
{
    public class MoveDownCommand : ICommand
    {
        private Game1 game;

        public MoveDownCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.MoveDown();
        }
    }
}