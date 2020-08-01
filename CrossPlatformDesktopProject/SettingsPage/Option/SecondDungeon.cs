using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class SecondDungeon : AbstractOption
    {
        public SecondDungeon(Vector2 position, Color color)
        {
            Position = position;
            Color = color;
        }

        public override void Select()
        {
            AddToPageStack();
            Constant.DungeonGridWidth = 4;
            Constant.DungeonGridHeight = 8;
            GameObjects.Instance.LevelListPosition = 29;
            GameObjects.Instance.DungeonRoomCount = 31;
            LevelXMLReader.fileString = "\\Room\\Dungeon2.xml";
            Game1.Instance.State = new StateClassicGame();
        }

        public override void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.DrawString(spriteFont, "Dungeon - 2", Position, Color);
        }
    }
}
