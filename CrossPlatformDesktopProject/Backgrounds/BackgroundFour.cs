
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundFour : AbstractBackground
    {
        public BackgroundFour()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundFour();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
