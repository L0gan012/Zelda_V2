
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundTwelve : AbstractBackground
    {
        public BackgroundTwelve()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundTwelve();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
