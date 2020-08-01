using System;
namespace Sprint2
{
    public class GoBackCommand : ICommand
    {
        public string Description { get; }

        public GoBackCommand()
        {
            Description = StringConstants.GoBackDescritopn;
        }

        public void Execute()
        {
            if(Game1.Instance.State is StateSettings && ((StateSettings)Game1.Instance.State).PreviousPages.Count > 0)
            { 
                ((StateSettings)Game1.Instance.State).SettingsPage = ((StateSettings)Game1.Instance.State).PreviousPages.Pop();
            }
        }
    }
}
