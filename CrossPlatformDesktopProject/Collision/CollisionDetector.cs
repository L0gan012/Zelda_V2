using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Collision
{
    public class CollisionDetector
    {
        Game1 game;
        IBlock block1;
        ILink link;
        Rectangle Hitbox1;
        Rectangle Hitbox2;

        public CollisionDetector(Game1 game)
        {
            this.game = game;
        }

        public void Update()
        {
            block1 = game.ListOfBlocks[game.BlockListPosition];
            link = game.Link;
            Hitbox1 = block1.getDestinationRectangle();
            Hitbox2 = link.State.Sprite.GetHitbox();
            if (Hitbox1.Intersects(Hitbox2))
            {
                Console.WriteLine("Collide!");
            }
            else
            {
                Console.WriteLine(Hitbox1.Center);
                Console.WriteLine(Hitbox2.Center);
            }
        }
    }
}
