namespace Sprint2
{
    public class UseItem1Command : ICommand
    {
        private Game1 game;

        public UseItem1Command(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.Item = new UsableBomb(this.game.Link);
            game.Link.UseItem();
        }
    }
}