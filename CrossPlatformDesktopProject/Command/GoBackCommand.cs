using System;
namespace Sprint2
{
    public class GoBackCommand : ICommand
    {
        public GoBackCommand()
        {
        }

        public void Execute()
        {
            if(Game1.Instance.State is StateSettings)
            {
                ((StateSettings)Game1.Instance.State).SettingsPage = ((StateSettings)Game1.Instance.State).PreviousPage;
            }
        }
    }
}
