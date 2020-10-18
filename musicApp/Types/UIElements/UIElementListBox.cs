using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.Types.UIElements
{
    public class UIElementListBox : UIElement
    {
        //used to store elements in a box
        public UIElementListBox(int x, int y, int sizex, int sizey) : base(x, y, sizex, sizey) { }
        public UIElementListBox(int x, int y) : base(x, y) { }

        public List<UIElement> uiElements = new List<UIElement>();

        public UIElement getElement(string name)
        {
            //Find the element by name and return it!
            return uiElements.Find(ui => ui.name == name);
        }

        public UIElement getElement(UIElement element)
        {
            //Find the element by element object and return it!
            return uiElements.Find(ui => ui == element);
        }

        public UIElement AddElement(UIElement element)
        {
            //Add an element into the listbox here but check if it exists or not
            if (ElementExists(element) || ElementExists(element.name))
            {
                //Element Exists
                Console.WriteLine("This element already exists!");
            }
            else
            {
                uiElements.Add(element);
            }
            return uiElements.Find(ui => ui == element);
        }

        public UIElement AddElement(string name)
        {
            if (!ElementExists(name))
            {
                //Add this element by name
                UIElement element = new UIElement(name);
                uiElements.Add(element);
                Console.WriteLine("Its not recommended to add element by name!!!");
            }
            else
            {
                Console.WriteLine("This element already exists!");
            }
            return uiElements.Find(ui => ui.name == name);
        }

        public void RemoveElement(UIElement element)
        {
            //Remove an element here from the list box
            if (!ElementExists(element))
            {
                Console.WriteLine("This element doesnt exist!");
            }
            else
            {
                uiElements.Remove(element);
            }
        }

        public void RemoveElement(string name)
        {
            //Remove an element from name in the list box
            if (!ElementExists(name))
            {
                //This element does not exist!
                Console.WriteLine("This element does not exist!!!");
            }
            else
            {
                uiElements.Remove(uiElements.Find(ui => ui.name == name));
                Console.WriteLine("Its not recommended to remove element by name!!!");
            }
        }

        public bool ElementExists(UIElement element)
        {
            //Check if the element exists here!!!
            bool elementExists = false;
            foreach(UIElement ele in uiElements)
            {
                if(element == ele)
                {
                    elementExists = true;
                }
            }
            return elementExists;
        }

        public bool ElementExists(string name)
        {
            //I could just call the previous but no im gonna make it better just in case :)
            bool elementExists = false;
            foreach(UIElement ele in uiElements)
            {
                if(ele.name == name)
                {
                    elementExists = true;
                }
            }
            return elementExists;
        }
    }
}
