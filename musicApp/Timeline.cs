using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicApp
{
    public struct Vector2
    {
        public int x;
        public int y;
    }

    public class UIElement
    {
        public int x;
        public int y;
        public int sizex;
        public int sizey;

        public UIElement(int x, int y, int sizex, int sizey)
        {
            this.x = x;
            this.y = y;
            this.sizex = sizex;
            this.sizey = sizey;
        }

        public UIElement(int x, int y)
        {
            this.x = x;
            this.y = y;
            sizex = 30;
            sizey = 30;
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

        public virtual void DrawElement(int mousex, int mousey)
        {
            //Draw the element!
        }
    }

    public enum SliderDirection
    {
        HORIZONTAL, VERTICAL
    }

    public class UIElementSlider : UIElement
    {
        public SliderDirection directionSlider;
        //ahhhhhh
        public UIElementSlider(int x, int y, int sizex, int sizey):base(x, y, sizex, sizey){}

        public UIElementSlider(int x, int y):base(x, y){}

        public override void DrawElement(int mousex, int mousey)
        {
            base.DrawElement(mousex, mousey);
            //Draw the Slider comeon PS: this is called on every frame....

        }
    }

    public class UIElementListBox : UIElement
    {
        //used to store elements in a box
        public UIElementListBox(int x, int y, int sizex, int sizey) : base(x, y, sizex, sizey) { }
        public UIElementListBox(int x, int y) : base(x, y) { }

        public List<UIElement> uiElements = new List<UIElement>();

        public void AddElement()
        {

        }

        public void RemoveElement()
        {

        }

        public bool ElementExists()
        {
            //Check if the element exists here!!!
            return false;
        }
    }

    public partial class Timeline : Form
    {
        public Timeline()
        {
            InitializeComponent();
        }

        //DRAWING OPTIONS FOR TIMELINE
        public void DrawSlider()
        {

        }
    }
}
