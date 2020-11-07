using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.Types.Drawing
{
    public class Canvas
    {
        public Vector2 canvasSize;

        //This is responsible for drawing everything and anything
        public virtual void SetupCanvas()
        {
            //Used for setting up the canvas.
            canvasSize = new Vector2(1280, 720);
        }

        public virtual void DrawRectangle(Rectangle rect)
        {

        }
    }
}
