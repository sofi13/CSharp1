/*Write an expression that checks for given point (x, y)
  if it is within the circle K( (1,1), 3) and out of 
  the rectangle R(top=1, left=-1, width=6, height=2).
 */

using System;

class PointOfCircleAndRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 9)
        {
            if (x < 1)
            {
                Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K((1,1),3) and out of the rectangle.", x, y);
            }
            else if (x >= 1 && y > -1)
            {
                Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K((1,1),3) and out of the rectangle.", x, y);
            }
            else
            {
                Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K((1,1),3) but is not out of the rectangle.", x, y);
            }
        }
        else
        {
            Console.WriteLine("The point is outside of the circle.");
        }
    }
}

