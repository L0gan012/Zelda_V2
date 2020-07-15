

namespace Sprint2.Sprite
{
    class AbstractAnimatedSpriteSingleRun : AbstractAnimatedSprite
    {
        protected int CurrentTick { get; set; }
        protected int TotalFrames { get; set; }
        protected int TicksPerFrame { get; set; }

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