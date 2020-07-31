using System;

namespace Sprint2
{
    class OpenScoreboardCommand : ICommand
    {
        public OpenScoreboardCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateClassicGame)
            {
                ((StateClassicGame)Game1.Instance.State).ShowScore();
            }
        }
    }
}
