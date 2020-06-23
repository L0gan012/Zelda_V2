
using Microsoft.Xna.Framework;

namespace Sprint2.Backgrounds
{
    public class BackgroundOne : AbstractBackground
    {

        public BackgroundOne()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundOne();
            Location = Constant.BackGroundStartPosition;
            Color = Color.White;

        }
    }
}
