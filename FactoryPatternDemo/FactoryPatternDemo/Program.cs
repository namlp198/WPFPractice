using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.GetShape("Circle");
            shape1.Draw();

            IShape shape2 = shapeFactory.GetShape("Rectangle");
            shape2.Draw();

            IShape shape3 = shapeFactory.GetShape("Square");
            shape3.Draw();

            Console.ReadLine();
        }
    }
}
