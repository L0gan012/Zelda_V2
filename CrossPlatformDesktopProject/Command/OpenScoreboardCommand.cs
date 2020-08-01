using System;

namespace Sprint2
{
    class OpenScoreboardCommand : ICommand
    {
        public string Description { get; }

        public OpenScoreboardCommand()
        {
            Description = StringConstants.OpenScoreboardDescription;
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
