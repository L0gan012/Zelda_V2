﻿namespace Sprint2
{
    public class UseItem7Command : ICommand
    {

        public UseItem7Command()
        {
        }

        public void Execute()
        {
            UsableBow bow = new UsableBow(Game1.Instance.Link);
            bow.Type = Enumerations.ArrowType.silver;
            Game1.Instance.Link.SecondaryItem = bow;
            Game1.Instance.Link.UseItem();
        }
    }
}