using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class Camera
    {
        //Used to draw camera on screen
        public Matrix transform;
        //Used to set where the camera is currently looking
        Viewport view;
        //Center of camera
        Vector2 center;

        public Camera(Viewport newView)
        {
            view = newView;
        }

        public void Update()
        {
            center = new Vector2(400, 240);
            transform = Matrix.CreateScale(new Vector3(1, 1, 0)) * Matrix.CreateTranslation(new Vector3(-center.X, -center.Y, 0));

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, transform);
            //spriteBatch.End();
        }
    }
}
