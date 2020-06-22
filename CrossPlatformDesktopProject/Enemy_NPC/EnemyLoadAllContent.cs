namespace Sprint2
{
    public class EnemyLoadAllContent
    {
        Game1 game;
        
        public EnemyLoadAllContent(Game1 game)
        {
            this.game = game;
        }

        public void LoadContent()
        {
            game.ListOfEnemies.Add(new Aquamentus());
            //game.ListOfEnemies.Add(new OldMan());
            //game.ListOfEnemies.Add(new Dodongo());
            game.ListOfEnemies.Add(new Gel());
            game.ListOfEnemies.Add(new SpikeCross());
            game.ListOfEnemies.Add(new Keese());
            game.ListOfEnemies.Add(new Stalfos());
        }
    }
}
