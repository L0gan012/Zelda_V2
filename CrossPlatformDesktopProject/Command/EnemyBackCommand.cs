namespace Sprint2
{
    public class EnemyBackCommand : ICommand
    {
        private Game1 game;

        public EnemyBackCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (game.EnemyListPosition > 0) 
            { 
                game.EnemyListPosition--; 
            }
        }
    }
}