
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundThirteen : AbstractBackground
    {
        public BackgroundThirteen()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundThirteen();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
