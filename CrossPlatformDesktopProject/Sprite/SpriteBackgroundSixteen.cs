using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class SpriteBackgroundSixteen : AbstractSprite
    {
        public SpriteBackgroundSixteen(Texture2D texture)
        {
            Texture = texture;
            CurrentFrame = 0;
            Rows = 1;
            Columns = 1;
        }

        public override void Draw(SpriteBatch spriteBatch, Color color, Vector2 location)
        {
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = CurrentFrame / Columns;
            int column = CurrentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, Constant.ScreenWidth, Constant.ScreenHeight);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, color);
            spriteBatch.End();
        }

        public override int GetHeight()
        {
            //int height = Texture.Height * Constant.DisplayScaleY / Rows;
            return Constant.ScreenHeight;
        }

        public override int GetWidth()
        {
            //int width = Texture.Width * Constant.DisplayScaleX / Columns;
            return Constant.ScreenWidth;
        }
    }
}