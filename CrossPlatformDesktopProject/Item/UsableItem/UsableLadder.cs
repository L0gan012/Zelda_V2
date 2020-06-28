using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableLadder : AbstractUsable
    {
        public UsableLadder(ILink link)
        {
            User = link;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteLadder();
        }

    }
}
