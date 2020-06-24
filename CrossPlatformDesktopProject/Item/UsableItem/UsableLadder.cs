using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableLadder : AbstractUsable
    {
        public UsableLadder(ILink link)
        {
            Link = link;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteLadder();
            Color = Color.White;
        }

    }
}
