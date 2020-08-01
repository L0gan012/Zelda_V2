using Microsoft.Xna.Framework.Graphics;
using Sprint2.Sprite;

namespace Sprint2
{
    public class DebugDrawHitBoxesCommand : ICommand
    {
        public string Description { get; }

        public DebugDrawHitBoxesCommand()
        {
            Description = StringConstants.DebugDrawHitBoxesDescription;
        }
        public void Execute()
        {
 
        }
   
        
    }
}