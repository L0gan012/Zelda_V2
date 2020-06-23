namespace Sprint2
{
    public class EnemyLoadAllContent
    {
        GameObjects objects;
        
        public EnemyLoadAllContent(Game1 game)
        {
            objects = new GameObjects(game);
        }

        public void LoadContent()
        {
            objects.ListOfEnemies.Add(new Aquamentus());
            //game.ListOfEnemies.Add(new OldMan());
            //game.ListOfEnemies.Add(new Dodongo());
            objects.ListOfEnemies.Add(new Gel());
            objects.ListOfEnemies.Add(new SpikeCross());
            objects.ListOfEnemies.Add(new Keese());
            objects.ListOfEnemies.Add(new Stalfos());
        }
    }
}
