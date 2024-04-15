namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# LINQ

            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(num => num % 2 == 0);
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            List<int> gardes = new List<int> { 85, 90, 80, 70, 88 };
            double averageGrade = gardes.Average();
            Console.WriteLine("Average Grade: " + averageGrade);


            // C# Functions Task 1
            GreetUser("Yara");

            // C# Functions Task 2
            double volume = CalculateVolume(2, 3, 4);
            Console.WriteLine("Volume of the box : " + volume);

            // Bonus
            double cubeVolume = CalculateVolume(5);
            Console.WriteLine("Volume of the cube: " + cubeVolume);

            double cylinderVolume = CalculateVolume(2, 5);
            Console.WriteLine("Volume of the cylinder: " + cylinderVolume);
        }

        // C# Functions Task 1
        static void GreetUser(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        // C# Functions Task 2
        static double CalculateVolume(double length, double width, double height)
        {
            return length * width * height;
        }

        // Bonus
        static double CalculateVolume(double sideLength)
        {
            return Math.Pow(sideLength, 3);
        }

        static double CalculateVolume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
    }


}

   

