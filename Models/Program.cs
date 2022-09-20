using System;
using System.Collections.Generic;
using TriangleChecker.Models;

public class Program 
{
  static void Main()
  {
    Triangle testTriangle = new Triangle();

    Console.WriteLine("Please enter Side 1:");
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter Side 2:");
    int B = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter Side 3:");
    int C = int.Parse(Console.ReadLine());
  
    if (!testTriangle.IsValidTriangle(A,B,C)) 
    {
      Console.WriteLine("This is not a Valid triangle");
    }
    else if (testTriangle.IsScalene(A,B,C)) 
    {
      Console.WriteLine("This is an Scalene triangle");
    }
    else if (testTriangle.IsEquilateral(A,B,C))
    {
      Console.WriteLine("This is an Equilateral triangle");
    }
    else if (testTriangle.IsIsosceles(A,B,C)) 
    {
      Console.WriteLine("This is an Isosceles triangle");
    }
  }
}