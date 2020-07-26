using System;
namespace Sprint2
{
    public class OpenSettingsFromPausedCommand : ICommand
    {
        public OpenSettingsFromPausedCommand()
        {
        }

        public void Execute()
        {
            if(Game1.Instance.State is StatePaused)
            {
                Game1.Instance.State = new StateSettings(Game1.Instance.State);
                ((StateSettings)Game1.Instance.State).SettingsPage = new PreferencesPage();
            }
        }
    }
}
