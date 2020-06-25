
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BackgroundThree : AbstractBackground
    {
        public BackgroundThree()
        {
            Sprite = BackgroundSpriteFactory.Instance.CreateSpriteBackgroundThree();
            Position = Constant.BackGroundStartPosition;
            Color = Color.White;
        }
    }
}
