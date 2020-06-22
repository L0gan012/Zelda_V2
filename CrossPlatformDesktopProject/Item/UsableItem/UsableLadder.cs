using Microsoft.Xna.Framework;
using Sprint2.Factory;

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

        public override void Update()
        {

        }
    }
}
