using Microsoft.Xna.Framework.Graphics;
using Sprint2.Sprite;

namespace Sprint2
{

    public class DebugDrawHitBoxesCommand : ICommand
    {
        private Game1 game;
        public DebugDrawHitBoxesCommand(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
 
        }
   
        
    }
}