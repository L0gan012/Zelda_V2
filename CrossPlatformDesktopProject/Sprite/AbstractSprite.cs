using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public abstract class AbstractSprite : ISprite
    {
        protected Texture2D Texture { get; set; }
        protected int Rows { get; set; }
        protected int Columns { get; set; }
        protected int CurrentFrame { get; set; }
        public int TotalFrames { get; set; } = 1;
        public int TicksPerFrame { get; set; } = 0;

        public virtual void Update()
        {
        }

        public virtual void Draw(SpriteBatch spriteBatch, Color color, Vector2 location)
        {
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = CurrentFrame / Columns;
            int column = CurrentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * Constant.DisplayScaleX, height * Constant.DisplayScaleY);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, color);
            
        }

        public virtual int GetHeight()
        {
            int height = Texture.Height * Constant.DisplayScaleY / Rows;
            return height;
        }

        public virtual int GetWidth()
        {
            int width = Texture.Width * Constant.DisplayScaleX / Columns;
            return width;
        }
    }
}
