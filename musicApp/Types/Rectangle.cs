using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicApp.Types
{
    public class Rectangle
    {
        public Vector2 position;
        public Vector2 size;

        public Rectangle(Vector2 position, Vector2 size)
        {
            this.position = position;
            this.size = size;
        }

        public Rectangle(int positionX, int positionY, int sizeX, int sizeY)
        {
            this.position = new Vector2(positionX, positionY);
            this.size = new Vector2(sizeX, sizeY);
        }

        public Rectangle(Vector2 position)
        {
            this.position = position;
            this.size = new Vector2(10, 10);
        }

        public Rectangle(int positionX, int positionY)
        {
            this.position = new Vector2(positionX, positionY);
            this.size = new Vector2(10, 10);
        }
    }
}
