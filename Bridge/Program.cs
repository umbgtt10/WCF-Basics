using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface DrawApi
    {
        void DrawCircle(int radius, int x, int y);
    }

    public class RedCircle : DrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: " + radius + ", x: " + x + ", " + y + "]");
        }
    }

    public class GreenCircle : DrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: " + radius + ", x: " + x + ", " + y + "]");
        }
    }

    public abstract class Shape
    {
        protected DrawApi DrawApi;

        protected Shape(DrawApi drawApi)
        {
            DrawApi = drawApi;
        }
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius, DrawApi drawApi) : base(drawApi)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            DrawApi.DrawCircle(radius, x, y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var redCircle = new Circle(100,100,10, new RedCircle());
            var greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();

            Console.ReadKey();
        }
    }
}
