using Microsoft.Xna.Framework.Graphics;
using Sprint2.Backgrounds;
using System.Collections.Generic;


namespace Sprint2.Room
{
    public abstract class AbstractRoom : IRoom
    {

        protected IBackground Background { get; set; }

        protected int RoomNumber {get; set;}
        protected List<IItem> CurrentRoomItems { get; set; }

        protected List<INPC> CurrentRoomEnemies { get; set; }

        protected List<IBlock> CurrentRoomBlocks { get; set; }


        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(IItem item in CurrentRoomItems)
            {
                item.Draw(spriteBatch);
            }

            foreach (INPC character in CurrentRoomEnemies)
            {
                character.Draw(spriteBatch);
            }

            /*foreach (IBlock block in CurrentRoomBlocks)
            {
                block.Draw(spriteBatch);
            }*/
           

        }

        public void Update()
        {

        }

        public abstract void LoadRoom();

    }
}
