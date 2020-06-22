namespace Sprint2
{
    public class UseItem5Command : ICommand
    {
        private Game1 game;

        public UseItem5Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.Item = new UsableMagicBoomerang(game.Link);
            game.Link.UseItem();
        }
    }
}