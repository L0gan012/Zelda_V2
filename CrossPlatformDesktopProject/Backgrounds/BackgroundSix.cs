
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundSix : AbstractBackground
    {
        public BackgroundSix()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundSix();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
