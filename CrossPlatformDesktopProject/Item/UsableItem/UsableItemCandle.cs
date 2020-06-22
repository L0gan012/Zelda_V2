using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableItemCandle : AbstractItem, IUsableItem
    {
        private ILink link;

        public UsableItemCandle(ILink link)
        {
            this.link = link;
            Color = Color.White;
        }

        public void UseDown()
        {

        }

        public void UseLeft()
        {

        }

        public void UseRight()
        {

        }

        public void UseUp()
        {

        }

    }
}
