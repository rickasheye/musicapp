using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.Types.UIElements
{
    public class UIElementText : UIElement
    {
        //ahhhhhh
        public UIElementText(int x, int y) : base(x, y) { }

        public UIElementText(int x, int y, string font, string text) : base(x, y) { this.font = font; this.text = text; }

        public UIElementText(int x, int y, string text) :base(x, y) { this.font = "Arial"; this.text = text; }

        public string font;
        public string text;

        public override void DrawElement(Graphics graphics)
        {
            base.DrawElement(graphics);
            graphics.DrawString(text, SystemFonts.GetFontByName(font), new SolidBrush(Color.Black), new Point(x, y));
        }
    }
}
