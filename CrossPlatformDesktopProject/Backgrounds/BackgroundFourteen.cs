
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundFourteen : AbstractBackground
    {
        public BackgroundFourteen()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundFourteen();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
