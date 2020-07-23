using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public class ResetCommand : ICommand
    {

        public ResetCommand()
        {

        }

        public void Execute()
        {
            Game1.Instance.State = new StateGameStart(Game1.Instance.State);
            Game1.Instance.Controllers[0].UpdateCommand(Keys.Space, new StartCommand());
            Game1.Instance.Controllers[0].UpdateCommand(Keys.Tab, new GameSelectionCommand());
            Game1.Instance.Controllers[0].UpdateCommand(Keys.F, new NullCommand());
            Game1.Instance.Controllers[0].UpdateCommand(Keys.B, new NullCommand());
            Game1.Instance.Link = new Link();
            GameObjects.Instance.LevelListPosition = 32;
            GameObjects.Instance.UpdateRoom();

        }
    }
}
