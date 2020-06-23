using Sprint2.Backgrounds;

namespace Sprint2
{
    public class BackgroundLoadAllContent
    {
        private GameObjects objects;

        public BackgroundLoadAllContent(Game1 game)
        {
            objects = new GameObjects(game);
        }

        public void LoadContent()
        {
            objects.ListOfBackgrounds.Add(new BackgroundOne());
        }
    }
}
