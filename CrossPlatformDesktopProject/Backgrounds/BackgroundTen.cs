
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundTen : AbstractBackground
    {
        public BackgroundTen()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundTen();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
