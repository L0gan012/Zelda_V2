
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundOne : AbstractBackground
    {
        public BackgroundOne()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundOne();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
