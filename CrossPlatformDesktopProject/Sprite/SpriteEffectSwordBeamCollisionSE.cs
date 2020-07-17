using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    class SpriteEffectSwordBeamCollisionSE : AbstractAnimatedSprite
    {
        public SpriteEffectSwordBeamCollisionSE(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 4;
            CurrentFrame = 0;
            CurrentTick = 0;
            TotalFrames = Rows * Columns;
            TicksPerFrame = Constant.TicksPerFrameSwordBeamCollision;
        }
    }
}
