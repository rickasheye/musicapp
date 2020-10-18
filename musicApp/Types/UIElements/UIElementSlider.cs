using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.Types.UIElements
{
    public enum SliderDirection
    {
        HORIZONTAL, VERTICAL
    }

    public class UIElementSlider : UIElement
    {
        public SliderDirection directionSlider;
        //ahhhhhh
        public UIElementSlider(int x, int y, int sizex, int sizey) : base(x, y, sizex, sizey) { CheckParentForChildren(); }

        public UIElementSlider(int x, int y) : base(x, y) { CheckParentForChildren(); }

        List<UIElement> elements = new List<UIElement>();
        bool draw = true;
        public void CheckParentForChildren()
        {
            //Check if the thing outside this element is a list box if its null or not it then dont do anything
            UIElementListBox convert = parent as UIElementListBox;
            if(parent == null || convert == null)
            {
                Console.WriteLine("Slider parent is null!!!! or the parent isnt a listbox!!!");
                draw = false;
            }
            else
            {
                Console.WriteLine("Adjusting slider to listbox elements from parent...");
                //Adjust the box to suit these conditions!
                elements = convert.uiElements;
            }
        }

        int position = 1;
        public override void DrawElement(int mousex, int mousey, Graphics g)
        {
            base.DrawElement(mousex, mousey, g);
            //Draw the Slider comeon PS: this is called on every frame....
            if (draw != false)
            {
                //Still want to draw a rectange just want to adjust where the slider acts.
                g.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(new Point(x, y), new Size(sizex, sizey)));
                switch (directionSlider)
                {
                    case SliderDirection.HORIZONTAL:
                        //Draw the slider on a horizontal axis!!!
                        g.DrawRectangle(new Pen(new SolidBrush(Color.Gray)), new Rectangle(new Point(x * position, y), new Size((sizex / elements.Count) * position, sizey)));
                        //When the mouse if over the bar
                        if(mousex > x * position && mousex < x + sizex * position)
                        {
                            if(mousey > y * position && mousey < y + sizey * position)
                            {
                                //Move from the left to the right
                                position = mousex;
                            }
                        }
                        break;
                    case SliderDirection.VERTICAL:
                        //Draw the slider on a vertical axis!!!
                        g.DrawRectangle(new Pen(new SolidBrush(Color.Gray)), new Rectangle(new Point(x, y), new Size(sizex, sizey /elements.Count)));
                        if (mousex > x && mousex < x + sizex / elements.Count)
                        {
                            if (mousey > y && mousey < y + sizey / elements.Count)
                            {
                                //Move from the top to the bottom
                                position = mousey;
                            }
                        }
                        break;
                } 
            }
        }

        public void UpdateElements()
        {
            foreach(UIElement ele in elements)
            {
                switch (directionSlider)
                {
                    case SliderDirection.HORIZONTAL:
                        ele.SetPosition(ele.x * position, ele.y);
                        break;
                    case SliderDirection.VERTICAL:
                        ele.SetPosition(ele.x, ele.y * position);
                        break;
                }
            }
        }
    }
}
