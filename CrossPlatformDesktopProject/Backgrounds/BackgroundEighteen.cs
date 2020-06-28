using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundEighteen : AbstractBackground
    {
        public BackgroundEighteen()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundEighteen();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
