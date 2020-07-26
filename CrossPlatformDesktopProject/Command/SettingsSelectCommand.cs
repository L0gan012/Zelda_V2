using System;
namespace Sprint2
{
    public class SettingsSelectCommand : ICommand
    {
        public SettingsSelectCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateSettings)
            {
                ((StateSettings)Game1.Instance.State).SettingsPage.selectOption();
            }

        }
    }
}
