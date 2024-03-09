


using Task2;

var shape=Shape.CalcCircleArea(3);
System.Console.WriteLine($"CalcCircleArea: {shape}");
System.Console.WriteLine($"_________________");
var calcPerimetr = Shape.CalcCirclePerimeter(2);
System.Console.WriteLine($"CalcCirclePerimeter:{calcPerimetr}");
System.Console.WriteLine($"_________________");

var recArea= Shape.CalcRectanglePerimeter(4,5);
System.Console.WriteLine($"CalcRectanglePerimeter: {recArea}");
System.Console.WriteLine($"________________");

var recPerimetr=Shape.CalcRectanglePerimeter(4,5);
    System.Console.WriteLine($".CalcRectanglePerimeter: {recPerimetr}");
System.Console.WriteLine($"----------------------");

var triArea= Shape.CalcTriangleArea(4,6);

System.Console.WriteLine($".CalcTriangleArea: {triArea}");

var triPerimetr=Shape.CalcTrianglePerimeter(4,5,6);
System.Console.WriteLine($"CalcTrianglePerimeter: {triPerimetr}");