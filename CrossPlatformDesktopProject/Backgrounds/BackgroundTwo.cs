
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundTwo : AbstractBackground
    {
        public BackgroundTwo()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundOne();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
