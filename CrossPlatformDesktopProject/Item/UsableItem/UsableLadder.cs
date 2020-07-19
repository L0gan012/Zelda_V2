using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableLadder : AbstractUsable
    {
        public UsableLadder(IGameObject user)
        {
            User = user;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteLadder();
            InventoryPosition = Constant.LadderInventoryPosition;
        }

    }
}
