using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            switch (shapeType)
            {
                case "":
                    return null;
                case "Circle":
                    return new Circle();
                case "Rectangle":
                    return new Rectangle();
                case "Square":
                    return new Square();
                default:
                    return null;
            }
        }
    }
}
