
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundNine : AbstractBackground
    {
        public BackgroundNine()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundNine();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
