using System;

namespace AreasLibrary
{
    public class Figure
    {
        public List<float> sides { get; set; }
        public float radius { get; set; }
        public Figure(float radius, List<float> sides)
        {
            this.sides = sides;
            this.radius = radius;
        }

        public void CheckRadius()
        {
            if (radius <= 0) throw new ArgumentException("Радиус должен быть больше нуля");
        }
        public void CheckSides()
        {
            foreach (var side in sides)
            {
                if (side <= 0) throw new ArgumentException("Стороны должна быть больше нуля");
            }
        }

        public double? AreaCircle()
        {
            CheckRadius();
            return Math.PI * radius * radius;
        }

        public double? AreaTriangle()
        {
            CheckSides();
            sides.Sort();
            float c = sides[2];//самая большая сторона - гипотенуза
            float b = sides[1];
            float a = sides[0];

            //проверка на то, является ли треугольник прямоугольным
            bool rightTriangle = c * c == (a * a + b * b);//Math.Pow(число, степень)
            if (rightTriangle)
            {
                //определение площади прямоугольного треугольника
                return (a * b) / 2;
            }
            else
            {
                //определение площади любого треугольника
                float p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));//sqrt - корень квадратный
            }
        }
    }
}
