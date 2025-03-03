namespace HassanRepetition
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
            int age = 25;
            double height = 1.75;
            double weight = 70.5;
            char Initial = 'A';
            string Name = "Alice";
            bool Is_Student = true;
            Console.WriteLine($"Age: {age}, Height: {height}, Weight: {weight}, Initial: {Initial}, Name: {Name}, Is Student: {Is_Student}");
            */
            /*
            
            //Degrees
            int Celsius = 25;
            int Fahrenheit = 77;
            int Celsius_To_Fahrenheit = 25 * 9 / 5 + 32;
            Console.WriteLine(Celsius_To_Fahrenheit);
            int FahrenHeit_To_Celsius = (77 - 32) * 5 / 9;
            Console.WriteLine(FahrenHeit_To_Celsius);
            Console.WriteLine($"{Celsius}°C Is {Fahrenheit}°F");
            Console.WriteLine($"{Fahrenheit}°F is {Celsius}°C");
          */

            //Height calculation
            /*
            Console.WriteLine("Enter your Height");
            string input = Console.ReadLine();
            float height;
            if (float.TryParse(input, out height))
            {
                Console.WriteLine($"Your height is: {height}");
            } else
            {
                Console.WriteLine("Invalid input, try again");
            }
            //Weight calculation
            Console.WriteLine("Enter your Weight");
            string input2 = Console.ReadLine();
            float weight;
            if (float.TryParse(input2, out weight))
            {
                Console.WriteLine($"Your weight is: {weight}");
            } else
            {
                Console.WriteLine("Invalid input, try again");
            }
            float BMI = weight / (height * height);
            Console.WriteLine(BMI);
            */
            /*
            // Arithmetics
            int sum = 5 + 10;
            int difference = sum - 10;
            int product = difference * 10;
            int quotient = product / 25;
            int remainder = quotient - 2;
            Console.WriteLine($"Sum: {sum} , difference: {difference}, product: {product}, quotient: {quotient}, remainder: {remainder}");
            */


            /*
            //Radius calculation
            
                Console.WriteLine("Enter your radius");
            string input = Console.ReadLine();
            float radius;
            if (float.TryParse(input, out radius))
            {
                Console.WriteLine($"Your radius is: {radius}");
            }
            else
            {
                Console.WriteLine("Invalid input, try again");
            }
            //Circumference calculation
            float circumference = 2 * 3.1415926535897931f * radius;
            Console.WriteLine($"The Circumference of the circle is {circumference}");
            //Areal calculation
            float Areal = 3.1415926535897931f * (radius * radius);
            Console.WriteLine($"Your circle's Areal is : {Areal}");
            */

            /*
            bool IsEqual = false;
            bool IsNotEqual = true;
            bool IsGreator= false;
            bool IsLess = true;
            bool IsGreatorOrEqual = false;
            bool IsLessOrEqual = true;
            Console.WriteLine($"Is Equal: {IsEqual}, Is Not Equal: {IsNotEqual}, Is Greator: {IsGreator}, Is Less: {IsLess}, Is Greator Or Equal {IsGreatorOrEqual}, Is Less Or Equal: {IsLessOrEqual}");
             */
            /*
            
            //Number check
            Console.WriteLine("Enter your favorite number: ");
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());
            if (favoriteNumber > 0)
            {
                Console.WriteLine("Your favorite number is positive");
            }
            else if (favoriteNumber < 0)
            {
                Console.WriteLine("Your favorite number is negative");
            }
            else if (favoriteNumber == 0)
            {
                Console.WriteLine("Your favorite number is 0");
            }

            else
            {
                Console.WriteLine("Please enter a valid number");
            }
            */
            //Grade check






            Console.WriteLine("Enter your grade, A, B, C, D, F: ");
            char grade = Char.Parse(Console.ReadLine());

            if (grade == 'A' || grade == 'B' || grade == 'C' || grade == 'D')
            {
                Console.WriteLine("You passed");
            }
            else if (grade == 'F')
            {
                Console.WriteLine("You failed");
            }
            else
            {
                Console.WriteLine("Invalid grade entered, please enter valid grade, A,B,C,D,F");
            }
            Console.ReadLine();

        }
    }
}
