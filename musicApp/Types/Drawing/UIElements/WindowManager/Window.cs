using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.Types.UIElements.WindowManager
{
    public class Window
    {
        public string WindowTitle;
        public WindowState state;

        public Vector2 WindowPosition;
        public Vector2 WindowSize;

        public int zindex;

        public Window(string WindowTitle)
        {
            //Just creates a basic window with a window title
            this.WindowTitle = WindowTitle;
            state = WindowState.OPEN;

            WindowPosition = new Vector2(0, 0);
            WindowSize = new Vector2(400, 400);
        }

        //Start with a closed window
        public Window(string WindowTitle, bool closed)
        {
            this.WindowTitle = WindowTitle;
            if(closed == true) { state = WindowState.CLOSED; } else { state = WindowState.OPEN; }

            WindowPosition = new Vector2(0, 0);
            WindowSize = new Vector2(400, 400);
        }

        public Window(string WindowTitle, bool closed, bool minimised)
        {
            this.WindowTitle = WindowTitle;
            if(closed == true) { state = WindowState.CLOSED; }else if(closed == false && minimised == false) { state = WindowState.OPEN; } else { state = WindowState.MINIMISED; }

            WindowPosition = new Vector2(0, 0);
            WindowSize = new Vector2(400, 400);
        }

        public Window(string WindowTitle, bool closed, bool minimised, Vector2 WindowPosition)
        {
            this.WindowTitle = WindowTitle;
            if (closed == true) { state = WindowState.CLOSED; } else if (closed == false && minimised == false) { state = WindowState.OPEN; } else { state = WindowState.MINIMISED; }

            this.WindowPosition = WindowPosition;
            WindowSize = new Vector2(400, 400);
        }

        public Window(string WindowTitle, bool closed, bool minimised, Vector2 WindowPosition, Vector2 WindowSize)
        {
            this.WindowTitle = WindowTitle;
            if (closed == true) { state = WindowState.CLOSED; } else if (closed == false && minimised == false) { state = WindowState.OPEN; } else { state = WindowState.MINIMISED; }

            this.WindowPosition = WindowPosition;
            this.WindowSize = WindowSize;
        }

        //This defines all of the constants for a basic window media.
        public virtual void UpdateWindow()
        {

        }

        public virtual void StartWindow()
        {

        }

        public virtual void WindowAwake()
        {

        }
    }
}
