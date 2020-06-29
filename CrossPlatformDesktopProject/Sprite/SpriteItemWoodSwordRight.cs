using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SpriteItemWoodSwordRight : AbstractAnimatedSprite
    {
        public SpriteItemWoodSwordRight(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 4;
            CurrentFrame = 0;
            CurrentTick = 0;
            TotalFrames = Rows * Columns;
            TicksPerFrame = Constant.TicksPerFrameAttackSword;
        }
    }
}
