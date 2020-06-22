namespace Sprint2
{
    public class MoveRightCommand : ICommand
    {
        private Game1 game;

        public MoveRightCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.MoveRight();
        }
    }
}