using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class EffectSwordBeamCollision : ISpriteEffect
    {
        public ISprite SpriteNE { get; set; }
        public ISprite SpriteNW { get; set; }
        public ISprite SpriteSE { get; set; }
        public ISprite SpriteSW { get; set; }
        public Vector2 PositionNE { get; set; }
        public Vector2 PositionNW { get; set; }
        public Vector2 PositionSE { get; set; }
        public Vector2 PositionSW { get; set; }
        public Color Color { get; set; } = Color.White;
        public Vector2 Velocity { get; set; }
        public bool IsDestructable { get; set; } = false;

        private int timer;

        public EffectSwordBeamCollision(Vector2 position)
        {
            SpriteNE = SpriteEffectSpriteFactory.Instance.CreateSpriteEffectSwordBeamCollisionNE();
            SpriteNW = SpriteEffectSpriteFactory.Instance.CreateSpriteEffectSwordBeamCollisionNW();
            SpriteSE = SpriteEffectSpriteFactory.Instance.CreateSpriteEffectSwordBeamCollisionSE();
            SpriteSW = SpriteEffectSpriteFactory.Instance.CreateSpriteEffectSwordBeamCollisionSW();
            timer = 0;
            PositionNE = position;
            PositionNW = position;
            PositionSE = position;
            PositionSW = position;
        }
        public void Update()
        {
            if (timer >= Constant.EffectSwordBeamCollisionTimer)
            {
                IsDestructable = true;
            }
            timer++;

            PositionNE = new Vector2(PositionNE.X + 1 * Constant.ArrowSpeed, PositionNE.Y + (-1 * Constant.ArrowSpeed));
            PositionNW = new Vector2(PositionNW.X + (-1 * Constant.ArrowSpeed), PositionNW.Y + (-1 * Constant.ArrowSpeed));
            PositionSE = new Vector2(PositionSE.X + (1 * Constant.ArrowSpeed), PositionSE.Y + (1 * Constant.ArrowSpeed));
            PositionSW = new Vector2(PositionSW.X + (-1 * Constant.ArrowSpeed), PositionSW.Y + (1 * Constant.ArrowSpeed));
            SpriteNE.Update();
            SpriteNW.Update();
            SpriteSE.Update();
            SpriteSW.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            SpriteNE.Draw(spriteBatch, Color, PositionNE);
            SpriteNW.Draw(spriteBatch, Color, PositionNW);
            SpriteSE.Draw(spriteBatch, Color, PositionSE);
            SpriteSW.Draw(spriteBatch, Color, PositionSW);
        }

    }
}
