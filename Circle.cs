using System.Drawing;

namespace RunGame
{
    class Circle
    {
        public Point center { get; private set; }
        public int radius   { get; private set; }
        public Color color  { get; private set; }

        public Circle(int x, int y, int r)
        {
            center = new Point(x, y);
            radius = r;
            color = Color.Blue;
        }


    }
}
