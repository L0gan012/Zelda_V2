using System;
namespace Sprint2
{
    public class SettingsCycleOptionCommand : ICommand
    {
        public string Description { get; }

        public SettingsCycleOptionCommand()
        {
            Description = StringConstants.CycleOptionDescription;
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
