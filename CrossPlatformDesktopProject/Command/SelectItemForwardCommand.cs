using System;
namespace Sprint2
{
    public class SelectItemForwardCommand : ICommand
    {
        public SelectItemForwardCommand()
        {

        }

        public void Execute()
        {
            if (Game1.Instance.state is StatePaused)
            {
                Game1.Instance.pauseHUD.itemSelector.SelectForward();
            }
        }
    }
}
