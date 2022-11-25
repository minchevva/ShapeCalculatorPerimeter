namespace shapeCalculatorPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countShapes = 0;

           countShapes = validate(countShapes, "Enter number of shapes", "Please enter a positive number");
            List<Shape> shapes = new List<Shape>();

            for(int i = 0; i < countShapes; i++)
            {
                Shape shape = new Shape();
                shapes.Add(shape);
            }

            Console.WriteLine(calculate(shapes));
        }

        static double calculate( List<Shape> shapes)
        {
            double sum = 0;
            double temp = 0;
            double per = 0;

            foreach (Shape shape in shapes)
            {
               shape.NumberOfSides = 0;
                do
                {
                    shape.NumberOfSides = validate(shape.NumberOfSides, "Enter Number Of Sides", "Please enter a positive number for sides");
                    if(shape.NumberOfSides < 3)
                    {
                        Console.WriteLine("There is no shape with less than 3 sides. Please enter again!");
                    } 
                } while (shape.NumberOfSides < 3);
              
               
                for(int i = 0; i < shape.NumberOfSides; i++)
                {
                    temp = validate(temp, "Enter a value for side #" + (i + 1), "Please enter a positive number for the value of the side");
                    per = per + temp;
                }
                sum = sum + per;
                per = 0;
            }

            return sum;
        }

        private static double validate(double number, String askEntry, String errorMessage)
        {

            do
            {
                try
                {
                    Console.WriteLine(askEntry);
                    number = Convert.ToDouble(Console.ReadLine());
                    if (number <= 0)
                    {
                        Console.WriteLine(errorMessage);
                    }
                }catch(Exception e)
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Try again!");
                    number = 0;
                }
                
            } while (number <= 0);
            return number;
        }
        private static int validate(int number, String askEntry, String errorMessage)
        {
            do
            {
                try
                {
                    Console.WriteLine(askEntry);
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number <= 0)
                    {
                        Console.WriteLine(errorMessage);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Try again!");
                    number = 0;
                }

            } while (number <= 0);
            return number;
        }
    }
}