using Microsoft.Xna.Framework.Graphics;

namespace Sprint2.Sprite
{
    class SpriteEnemyDeadEffectLarge : AbstractAnimatedSprite
    {
        public SpriteEnemyDeadEffectLarge(Texture2D texture)
        {
            Texture = texture;
            Rows = 1;
            Columns = 4;
            CurrentFrame = 0;
            CurrentTick = 0;
            TotalFrames = Rows * Columns;
            TicksPerFrame = Constant.TicksPerFrameEnemyDeath;
        }
    }
}
