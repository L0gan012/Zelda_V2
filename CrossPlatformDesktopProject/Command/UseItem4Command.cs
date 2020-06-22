namespace Sprint2
{
    public class UseItem4Command : ICommand
    {
        private Game1 game;

        public UseItem4Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.Item = new UsableBoomerang(game.Link);
            game.Link.UseItem();
        }
    }
}