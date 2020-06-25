
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundEleven : AbstractBackground
    {
        public BackgroundEleven()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundEleven();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
