using System;
namespace Sprint2
{
    public class SelectItemForwardCommand : ICommand
    {
        public string Description { get; }

        public SelectItemForwardCommand()
        {
            Description = StringConstants.SelectItemForwardDescription;
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
