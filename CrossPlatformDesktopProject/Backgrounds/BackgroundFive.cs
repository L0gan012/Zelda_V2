
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundFive : AbstractBackground
    {
        public BackgroundFive()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundFive();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
