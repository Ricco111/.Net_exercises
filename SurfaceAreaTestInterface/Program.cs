using System;

namespace SurfaceAreaTestInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DisplayMenu();
            var userInput = int.Parse(Console.ReadLine());

            
            switch (userInput)
            {
                case 1:
                    {
                        var circle = new Circle();
                        DisplaySecondMenu();
                        var secondUserInput = int.Parse(Console.ReadLine());
                        if (secondUserInput == 1)
                        {
                            circle.GetPerimeter();
                        }
                        else if (true)
                        {
                            circle.GetArea();
                        }
                        else
                        {
                            Console.WriteLine("Wrong action");
                        }

                        
                    }
                    break;
                case 2:
                    {
                        var triangle = new Triangle();
                        DisplaySecondMenu();
                        var secondUserInput = int.Parse(Console.ReadLine());
                        if (secondUserInput == 1)
                        {
                            triangle.GetPerimeter();
                        }
                        else if (true)
                        {
                            triangle.GetArea();
                        }
                        else
                        {
                            Console.WriteLine("Wrong action");
                        }
                    }
                    break;
                case 3:
                    {
                        var rectangle = new Rectangle();
                        DisplaySecondMenu();
                        var secondUserInput = int.Parse(Console.ReadLine());
                        if (secondUserInput == 1)
                        {
                            rectangle.GetPerimeter();
                        }
                        else if (true)
                        {
                            rectangle.GetArea();
                        }
                        else
                        {
                            Console.WriteLine("Wrong action");
                        }
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Wrong number");
                    }break;
            }
                       
            void DisplayMenu()
            {
                Console.WriteLine("Which figure would you like to choose ?");
                Console.WriteLine("1 - circle, 2- triangle, 3- Rectangle");                
            }

            void DisplaySecondMenu()
            {
                Console.WriteLine("Which calculation would you like to choose ?");
                Console.WriteLine("1 - perimeter, 2- area");
            }
        }
    }
}
