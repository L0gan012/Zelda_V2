﻿namespace Sprint2
{
    public class MoveLeftCommand : ICommand
    {

        public MoveLeftCommand()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.State is StateInLevel)
            {
                Game1.Instance.Link.MoveLeft();
            }
        }
    }
}
