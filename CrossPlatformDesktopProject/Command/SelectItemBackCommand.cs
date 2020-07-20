using System;
namespace Sprint2
{
    public class SelectItemBackCommand : ICommand
    {
        public SelectItemBackCommand()
        {

        }

        public void Execute()
        {
            if (Game1.Instance.state is StatePaused)
            {
                Game1.Instance.pauseHUD.itemSelector.SelectBack();
            }
        }
    }
}
