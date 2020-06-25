
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundFifteen : AbstractBackground
    {
        public BackgroundFifteen()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundFifteen();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
