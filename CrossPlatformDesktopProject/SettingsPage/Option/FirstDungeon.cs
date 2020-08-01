
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class FirstDungeon : AbstractOption
    {
        public FirstDungeon(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override void Select()
        {
            AddToPageStack();
            Constant.DungeonGridWidth = 6;
            Constant.DungeonGridHeight = 6;
            GameObjects.Instance.LevelListPosition = 32;
            GameObjects.Instance.DungeonRoomCount = 35;
            LevelXMLReader.fileString = "\\Room\\CurrentDungeonState.xml";
            Game1.Instance.State = new StateClassicGame();
        }

        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.DrawString(spriteFont, "Dungeon - 1", Position, Color);
        }
    }
}
