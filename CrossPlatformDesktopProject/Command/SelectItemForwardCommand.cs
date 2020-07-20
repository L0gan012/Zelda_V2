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
            if (Game1.Instance.State is StatePaused)
            {
                Game1.Instance.PauseHUD.ItemSelector.SelectForward();
            }
        }
    }
}
