namespace Sprint2
{
    public abstract class AbstractAnimatedSprite : AbstractSprite
    {
        protected int CurrentTick { get; set; }
        protected int TotalFrames { get; set; }
        protected int TicksPerFrame { get; set; }

        public override void Update()
        {
            if (CurrentTick >= TicksPerFrame)
            {
                CurrentTick = 0;
                CurrentFrame++;
                if (CurrentFrame >= TotalFrames)
                    CurrentFrame = 0;
            }
            CurrentTick++;
        }
    }
}
