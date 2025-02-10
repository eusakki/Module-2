using LabWork1._1_1_;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please, input the coordinates that will be at the beginning of the segment");
        Console.WriteLine("x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Now you need to input the coordinates that will be at the end of this segment");
        Console.WriteLine("x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        Segment segment = new Segment(x1, y1, x2, y2);

        Console.WriteLine("The coordinates of the start of the segment is: (" + x1 + "," + y1 + ")");
        Console.WriteLine("The coordinates of the end of the segment is: (" + x2 + "," + y2 + ")");
        Console.WriteLine("The segment's length is: " + segment.Length());
        Console.WriteLine("The angle between the OX axis is: " + segment.AngleOX());
    }
}