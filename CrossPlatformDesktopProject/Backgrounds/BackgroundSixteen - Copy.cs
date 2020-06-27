using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundSeventeen : AbstractBackground
    {
        public BackgroundSeventeen()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundSeventeen();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
