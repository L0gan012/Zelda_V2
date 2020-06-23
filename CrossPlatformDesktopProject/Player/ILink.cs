
namespace Sprint2
{
    public interface ILink : IPlayer
    {

        ILinkState State { get; set; }

        IUsableItem Item { get; set; }

        void UseItem();
    }
}
