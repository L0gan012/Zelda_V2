
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundEight : AbstractBackground
    {
        public BackgroundEight()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundEight();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
