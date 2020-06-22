namespace Sprint2
{
    public class MoveUpCommand : ICommand
    {
        private Game1 game;
 
        public MoveUpCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        { 
            game.Link.MoveUp();
        }
    }
}
