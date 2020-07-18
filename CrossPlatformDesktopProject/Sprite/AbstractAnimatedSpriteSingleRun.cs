

namespace Sprint2
{
    class AbstractAnimatedSpriteSingleRun : AbstractAnimatedSprite
    {
        public override void Update()
        {
            while (CurrentFrame <= TotalFrames)
            {
                if (CurrentTick >= TicksPerFrame)
                {
                    CurrentTick = 0;
                    CurrentFrame++;

                }
                CurrentTick++;
            }
        }
    }
}