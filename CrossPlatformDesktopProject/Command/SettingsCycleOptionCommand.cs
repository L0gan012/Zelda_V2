using System;
namespace Sprint2
{
    public class SettingsCycleOptionCommand : ICommand
    {
        public SettingsCycleOptionCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateSettings)
            {
                ((StateSettings)Game1.Instance.State).SettingsPage.cycleOption();
            }

        }
    }
}
