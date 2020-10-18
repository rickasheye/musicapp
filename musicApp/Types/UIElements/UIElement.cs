using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.Types.UIElements
{
    public class UIElement
    {
        public string name;
        public int x;
        public int y;
        public int sizex;
        public int sizey;

        public UIElement parent;

        public UIElement(string name, int x, int y, int sizex, int sizey)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.sizex = sizex;
            this.sizey = sizey;
            StartElement();
        }

        public UIElement(int x, int y, int sizex, int sizey)
        {
            this.x = x;
            this.y = y;
            this.sizex = sizex;
            this.sizey = sizey;
            StartElement();
        }

        public UIElement(int x, int y)
        {
            this.x = x;
            this.y = y;
            sizex = 30;
            sizey = 30;
            StartElement();
        }

        public UIElement(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            sizex = 30;
            sizey = 30;
            StartElement();
        }

        public UIElement(string name)
        {
            this.name = name;
            x = 30;
            y = 30;
            sizex = 30;
            sizey = 30;
            StartElement();
        }

        public UIElement()
        {
            name = "Untitled UI Element";
            x = 30;
            y = 30;
            sizex = 30;
            sizey = 30;
            StartElement();
        }

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetPosition(float x, float y)
        {
            this.x = (int)x;
            this.y = (int)y;
        }

        public void SetPosition(Vector2 position)
        {
            this.x = position.x;
            this.y = position.y;
        }

        public void SetSize(int sizex, int sizey)
        {
            this.sizex = sizex;
            this.sizey = sizey;
        }

        public void SetSize(float sizex, float sizey)
        {
            this.sizex = (int)sizex;
            this.sizey = (int)sizey;
        }

        public void SetSize(Vector2 size)
        {
            this.sizex = size.x;
            this.sizey = size.y;
        }

        public void SetSizePosition(int x, int y, int sizex, int sizey)
        {
            this.sizex = sizex;
            this.sizey = sizey;
            this.x = x;
            this.y = y;
        }

        public void SetParent(UIElement element)
        {
            this.parent = element;
        }

        public virtual void StartElement()
        {
            //When the element starts!
        }

        public virtual void DrawElement(Graphics graphics)
        {
            //Draw the element
        }

        public virtual void DrawElement(int mousex, int mousey, Graphics graphics)
        {
            //Draw the element!
        }
    }
}
