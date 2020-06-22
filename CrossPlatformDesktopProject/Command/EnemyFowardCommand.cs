namespace Sprint2
{
    public class EnemyFowardCommand : ICommand
    {
        private Game1 game;

        public EnemyFowardCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (game.EnemyListPosition < game.ListOfEnemies.Count - 1) 
            { 
                game.EnemyListPosition++; 
            }
        }
    }
}