using System;

namespace VirtualMethods
{
    public class Rectangle : Shape
    {
        public override void Draw() =>
            Console.WriteLine($"Rectangle with {Position} and {Size}");

        public override void Move(Position newPosition)
        {
            Console.Write("Rectangle ");
            base.Move(newPosition);
        }

        new public void MoveBy(int deltaX, int deltaY)
        {
            Console.Write("Rectangle ");
            var newPos = new Position
            {
                X = Position.X + deltaX,
                Y = Position.Y + deltaY
            };

            base.Move(newPos);
        }

        public override void Resize(int width, int height)
        {
            throw new NotImplementedException();
        }
    }

    public class Ellipse : Shape
    {
        public Ellipse()
            : base() { }

        public override void Resize(int width, int height)
        {
            Size.Width = width;
            Size.Height = height;
        }


        public override void Draw() =>
            Console.WriteLine($"Ellipse with {Position} and {Size}");
    }
}