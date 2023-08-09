using System;

abstract class Shape
{
    protected int dim1;
    protected int dim2;

    public Shape()
    {
        dim1 = dim2 = 0;
    }

    public Shape(int m)
    {
        dim1 = dim2 = m;
    }

    public Shape(int m, int n)
    {
        dim1 = m;
        dim2 = n;
    }

    public void SetDim1(int m)
    {
        dim1 = m;
    }

    public void SetDim2(int n)
    {
        dim2 = n;
    }

    public int GetDim1()
    {
        return dim1;
    }

    public int GetDim2()
    {
        return dim2;
    }

    public abstract float Area();
}

class Circle : Shape
{
    public Circle()
    {
    }

    public Circle(int r) : base(r) { }

    public override float Area()
    {
        return (3.14f * dim1 * dim1);
    }
}

class Rectangle : Shape
{
    public Rectangle()
    {
    }

    public Rectangle(int l, int w) : base(l, w) { }

    public override float Area()
    {
        return (1f * dim1 * dim2);
    }
}

class Triangle : Shape
{
    public Triangle()
    {
    }

    public Triangle(int b, int h) : base(b, h) { }

    public override float Area()
    {
        return (0.5f * dim1 * dim2);
    }
}

class Square : Rectangle
{
    public Square()
    {
    }

    public Square(int s) : base(s, s) { }
}

class GeoShape
{
    Shape C;
    Shape R;
    Shape T;
    Shape S;

    public GeoShape(Shape C, Shape R, Shape T, Shape S)
    {
        this.C = C;
        this.R = R;
        this.T = T;
        this.C = C;
    }

    public float TotalArea()
    {
        float total = C.Area() + R.Area() + T.Area() + S.Area();
        return total;
    }
}

class MyClass
{
    public static void Main(string[] args)
    {
        bool calculateAnotherArea = false;

        do
        {
            Console.WriteLine("Enter the shape for which you want to calculate the area:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Square");

            int shapeChoice = int.Parse(Console.ReadLine());

            float area = 0f;

            switch (shapeChoice)
            {
                case 1:
                    Console.WriteLine("Enter the radius of the circle:");
                    int circleRadius = int.Parse(Console.ReadLine());
                    Circle cr = new Circle(circleRadius);
                    area = cr.Area();
                    break;
                case 2:
                    Console.WriteLine("Enter the length of the rectangle:");
                    int rectangleLength = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the width of the rectangle:");
                    int rectangleWidth = int.Parse(Console.ReadLine());
                    Rectangle re = new Rectangle(rectangleLength, rectangleWidth);
                    area = re.Area();
                    break;
                case 3:
                    Console.WriteLine("Enter the base of the triangle:");
                    int triangleBase = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of the triangle:");
                    int triangleHeight = int.Parse(Console.ReadLine());
                    Triangle tr = new Triangle(triangleBase, triangleHeight);
                    area = tr.Area();
                    break;
                case 4:
                    Console.WriteLine("Enter the side length of the square:");
                    int squareSideLength = int.Parse(Console.ReadLine());
                    Square sq = new Square(squareSideLength);
                    area = sq.Area();
                    break;
                default:
                    Console.WriteLine("Wrong Number");
                    break;


                    //GeoShape g = new GeoShape(cr, re, tr, sq);

                    //float totalArea = g.TotalArea();
                    //Console.WriteLine("Total Area: " + totalArea);
            }

            Console.WriteLine("Area: " + area);

            Console.WriteLine("Do you want to calculate the area for another shape? (Y/N)");
            string input = Console.ReadLine();

            if (input == "y")
            {
                calculateAnotherArea = true;
            }
            else
            {
                calculateAnotherArea = false;
            }

        } while (calculateAnotherArea);
    }
}
