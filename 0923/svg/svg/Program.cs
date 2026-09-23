using System.Drawing;

namespace svg
{
    abstract class Shape
    {
        protected string stroke;
        protected Point firstPoint;

        public Shape(Point firstPoint, string stroke)
        {
            this.firstPoint = firstPoint;
            this.stroke = stroke;
        }

        public abstract new string ToString();

        public static void SVG2File(Shape[] shapes)
        {
            FileStream fs = new FileStream("mysvgfile.svg", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine($"<svg width=\"200\" height=\"200\" xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">");

            for(int i = 0; i < shapes.Length; i++)
            {
                sw.WriteLine("\t" + shapes[i].ToString());
            }

            sw.WriteLine($"</svg>");

            sw.Close();
            fs.Close();
        }
    }

    class Circle : Shape
    {
        protected double r;
        protected string fill;

        public Circle(double r, string fill, Point firstPoint, string stroke) : base(firstPoint, stroke)
        {
            this.r = r;
            this.fill = fill;
        }

        public override string ToString()
        {
            return $"<circle cx=\"{firstPoint.X}\" cy=\"{firstPoint.Y}\" r=\"{r}\" stroke=\"{stroke}\" fill=\"{fill}\"/>";
        }
    }

    class Rect : Shape
    {
        protected int width, height;
        protected string fill;

        public Rect(int width, int height, string fill, Point firstPoint, string stroke) :base(firstPoint, stroke)
        {
            this.width = width;
            this.height = height;
            this.fill = fill;
        }

        public override string ToString()
        {
            return $"<rect x=\"{firstPoint.X}\" y=\"{firstPoint.Y}\" width=\"{width}\" height=\"{height}\" stroke=\"{stroke}\" fill=\"{fill}\"/>";
        }
    }

    class Line : Shape
    {
        protected Point lastPoint;

        public Line(Point lastPoint, Point firstPoint, string stroke) :base(firstPoint, stroke)
        {
            this.lastPoint = lastPoint;
        }

        public override string ToString()
        {
            return $"<line x1=\"{firstPoint.X}\" y1=\"{firstPoint.Y}\" x2=\"{lastPoint.X}\" y2=\"{lastPoint.Y}\" stroke=\"{stroke}\"/>";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[9];
            shapes[0] = new Circle(20, "yellow", new Point(100, 50), "black");
            shapes[0] = new Line(new Point(100, 70), new Point(100, 90), "black");
            shapes[0] = new Circle(3, "blue", new Point(90, 45), "black");
            shapes[0] = new Circle(3, "blue", new Point(110, 45), "black");
            shapes[0] = new Rect(40, 70, "blue", new Point(80, 80), "black");
            shapes[0] = new Line(new Point(90, 150), new Point(60, 190), "black");
            shapes[0] = new Line(new Point(110, 150), new Point(140, 90), "black");
            shapes[0] = new Line(new Point(80, 90), new Point(40, 70), "black");
            shapes[0] = new Line(new Point(120, 90), new Point(160, 70), "black");

            Shape.SVG2File(shapes);
        }
    }
}
