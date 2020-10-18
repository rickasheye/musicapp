using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.Types.UIElements
{
    public class UIElementButton : UIElement
    {
        //ahhhhhh
        public UIElementButton(int x, int y, int sizex, int sizey) : base(x, y, sizex, sizey) { }

        public override void StartElement()
        {
            base.StartElement();
            //Start this button!!!
            if(text == null)
            {
                text = new UIElementText(x + 3, y + 3, "Arial", name);
            }
        }

        public UIElementText text;

        public override void DrawElement(int mousex, int mousey, Graphics graphics)
        {
            base.DrawElement(mousex, mousey, graphics);
            graphics.FillRectangle(new SolidBrush(Color.Black), new RectangleF(new Point(x, y), new Size(sizex, sizey)));

            if(mousex > x && mousex < x + sizex && mousey > y && mousey < y + sizey)
            {
                //make the color blue
                graphics.FillRectangle(new SolidBrush(Color.Blue), new RectangleF(new Point(x + 3, y + 3), new Size(sizex - 3, sizey - 3)));
            }
            else
            {
                graphics.FillRectangle(new SolidBrush(Color.Gray), new RectangleF(new Point(x + 3, y + 3), new Size(sizex - 3, sizey - 3)));
                TriggerElement();
            }
            text.DrawElement(graphics);
        }

        public virtual void TriggerElement()
        {

        }
    }
}
