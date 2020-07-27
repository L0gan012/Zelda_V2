using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableLadder : AbstractUsable
    {
        public UsableLadder(IGameObject user)
        {
            User = user;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteLadder();
            InventoryPosition = new Vector2(HUDConstants.LadderInventoryPosition.X * Constant.DisplayScaleX, HUDConstants.LadderInventoryPosition.Y * Constant.DisplayScaleY);
            DamageAmount = 0;
        }
    }
}
