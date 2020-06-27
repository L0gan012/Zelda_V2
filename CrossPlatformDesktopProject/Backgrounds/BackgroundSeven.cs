
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundSeven : AbstractBackground
    {
        public BackgroundSeven()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundSeven();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
