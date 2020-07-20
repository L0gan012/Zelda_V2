namespace Sprint2
{
    public interface ILink : IPlayer
    {
        ILinkState State { get; set; }


        void UseItem();
    }
}
