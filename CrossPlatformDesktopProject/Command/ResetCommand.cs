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
        }
    }
}
