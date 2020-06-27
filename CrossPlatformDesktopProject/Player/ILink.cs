namespace Sprint2
{
    public interface ILink : IPlayer
    {
        ILinkState State { get; set; }

        IUsableItem PrimaryItem { get; set; }

        IUsableItem SecondaryItem { get; set; }

        void UseItem();
    }
}
