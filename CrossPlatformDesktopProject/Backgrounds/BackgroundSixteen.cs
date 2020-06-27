using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundSixteen : AbstractBackground
    {
        public BackgroundSixteen()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundSixteen();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
