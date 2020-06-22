namespace Sprint2
{
    public class DamageCommand : ICommand
    {
        private Game1 game;
 
        public DamageCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.DamagePlayer();
        }
    }
}
