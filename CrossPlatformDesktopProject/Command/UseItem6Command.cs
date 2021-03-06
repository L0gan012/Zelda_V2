﻿namespace Sprint2
{
    public class UseItem6Command : ICommand
    {

        public UseItem6Command()
        {
        }

        public void Execute()
        {
            if (Game1.Instance.state is StateInLevel)
            {
                UsableBow bow = new UsableBow(Game1.Instance.Link);
                bow.Type = Enumerations.ArrowType.wooden;
                Game1.Instance.Link.SecondaryItem = bow;
                Game1.Instance.Link.UseItem();
            }
        }
    }
}