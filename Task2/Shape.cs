﻿namespace Task2;

public static class Shape
{

    public  static double Pi=3.14;
    public static double CalcCircleArea(double radius)
    {
    
    return Pi*radius*radius;

    }

    public static double CalcCirclePerimeter(double radius)
    {

        return 2*Pi*radius;
    }

public static double  CalcRectangleArea(double length, double width)
{

return length*width;

}   

public static double CalcRectanglePerimeter(double length, double width)
{

return 2*(length+width);

}

public static double  CalcTriangleArea(double b, double height)
{

return 0.5*b*height;

}


public static double CalcTrianglePerimeter(double side1, double side2, double side3)
{

return side1+side2+side3;

}



}
