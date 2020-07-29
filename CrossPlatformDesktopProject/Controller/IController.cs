using Microsoft.Xna.Framework.Input;

namespace Sprint2
{
    public interface IController
    {
        void Update();
        void RegisterCommand();
        void DeregisterCommands();
        void UpdateCommand(Keys key, ICommand commandClass);
    }
}
