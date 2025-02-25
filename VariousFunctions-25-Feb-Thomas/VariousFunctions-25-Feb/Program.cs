using System;
using System.Net.NetworkInformation;

namespace VariousFunctions_25_Feb
{
    class Functions
    {
        // Metode, der viser persondata
        public static void personData()
        {
            int age = 25;
            double height = 1.75;
            double weight = 70.5;
            char initial = 'A';
            string name = "Alice";
            bool isStudent = true;

            Console.WriteLine($"Age: {age}, Height: {height}, Weight: {weight}, Initial: {initial}, Name: {name}, Is Student: {isStudent}");
        }

        // Metoder, der konverterer temperaturer
        public static double celsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double fahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        public static void TemperatureConverter()
        {
            Console.WriteLine("\nVælg konvertering:\n");
            Console.WriteLine("1: Celsius til Fahrenheit");
            Console.WriteLine("2: Fahrenheit til Celsius");

            string choice =Console.ReadLine();

            Console.Write("Indtast temperatur: ");
            if(double.TryParse(Console.ReadLine(), out double temperature))

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Omregnet til Fahrenheit: {celsiusToFahrenheit(temperature):F2}");

                        if (temperature == 0)
                            Console.WriteLine("Fun fact: 32 F er frysepunktet for vand");
                        else if (temperature == 100)
                            Console.WriteLine("Fun fact: 212 F er kogepunktet for vand");
                        else if (temperature == -40)
                            Console.WriteLine("Fun fact: -40 C = -40 F (punktet, hvor de to skalaer mødes)");
                        break;
                    case "2":
                        Console.WriteLine($"Omregnet til Celsius: {fahrenheitToCelsius(temperature):F2}");
                        if (temperature == 32)
                            Console.WriteLine("Fun fact: 0 C er frysepunktet for vand");
                        else if (temperature == 212)
                            Console.WriteLine("Fun fact: 100 C er kogepunktet for vand");
                        else if (temperature == -40)
                            Console.WriteLine("Fun fact: -40 F = -40 C (punktet, hvor de to skalaer mødes)");
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen");
                        break;
                }
        }
        // Metode, der udregner BMI
        public static void CalculateBMI()
        {
            // Indtast vægt og højde
            Console.Write("Indtast din vægt i kg: ");
            // Tjekker, om inputtet ikke kunne konverteres til en double. Hvis konverteringen fejler, vil den første del af betingelsen være true.
            if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
            {
                Console.WriteLine("Ugyldig vægt. Prøv igen.");
                return;
            }

            Console.Write("Indtast din højde i meter: ");
            if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
            {
                Console.WriteLine("Ugyldig højde. Prøv igen.");
                return;
            }

            // Beregn BMI
            double bmi = weight / (height * height);

            // Udskriv BMI og klassificering
            Console.WriteLine($"Din BMI er: {bmi:F2}");

            if (bmi < 18.5)
                Console.WriteLine("Du er undervægtig.");
            else if (bmi >= 18.5 && bmi <= 24.9)
                Console.WriteLine("Du er normalvægtig.");
            else if (bmi >= 25 && bmi <= 29.9)
                Console.WriteLine("Du er overvægtig.");
            else
                Console.WriteLine("Du er svært overvægtig.");
        }
        // Metode, der udfører matematiske operationer
        public static void Calculate(double a, double b)
        {
            double sum = a + b;
            double difference = a - b;
            double product = a * b;
            double quotient = b != 0 ? a / b : double.NaN; // Her anvendes ternær operatør (Forklaring: condition ? value_if_true : value_if_false;)
            double remainder = b != 0 ? a % b : double.NaN;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {(b != 0 ? quotient.ToString() : "Undefined")}");
            Console.WriteLine($"Remainder: {(b != 0 ? remainder.ToString() : "Undefined")}");
        }
        // Metode til at beregne arealet og omkredsen af en cirkel
        public static void CalculateCircle(double radius)
        {
            double area = Math.PI * radius * radius;  // Cirklens areal
            double circumference = 2 * Math.PI * radius;  // Cirklens omkreds

            Console.WriteLine($"Arealet af cirklen er: {area:F2}");
            Console.WriteLine($"Omkredsen af cirklen er: {circumference:F2}");
        }
        // Metode til evaluering af udtryk
        public static void EvaluateExpressions(double a, double b)
        {
            // Is Equal
            Console.WriteLine($"Er {a} lig med {b}? {a == b}"); // Ternær operatør benyttes (condition ? value_if_true : value_if_false;)

            // Is Not Equal
            Console.WriteLine($"Er {a} ikke lig med {b}? {a != b}");

            // Is Greater
            Console.WriteLine($"Er {a} større end {b}? {a > b}");

            // Is Less
            Console.WriteLine($"Er {a} mindre end {b}? {a < b}");

            // Is Greater Or Equal
            Console.WriteLine($"Er {a} større end eller lig med {b}? {a >= b}");

            // Is Less Or Equal
            Console.WriteLine($"Er {a} mindre end eller lig med {b}? {a <= b}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nVælg en handling\n");
                Console.WriteLine("1: Print datatyper og deres værdier");
                Console.WriteLine("2: Konverter temperaturer");
                Console.WriteLine("3: BMI beregner");
                Console.WriteLine("4: Matematiske operationer");
                Console.WriteLine("5: Beregn areal og omkreds af cirkel");
                Console.WriteLine("6: Evaluer udtryk");
                Console.WriteLine("\nSkriv 'exit' for at afslutte");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Functions.personData(); // Kalder metoden
                        break;
                    case "2":
                        Functions.TemperatureConverter();
                        break;
                    case "3":
                        Functions.CalculateBMI();
                        break;
                    case "4":
                        Console.Write("Indtast det første tal: ");
                        if (!double.TryParse(Console.ReadLine(), out double num1))
                        {
                            Console.WriteLine("Ugyldigt input. Programmet afsluttes.");
                            return;
                        }

                        Console.Write("Indtast det andet tal: ");
                        if (!double.TryParse(Console.ReadLine(), out double num2))
                        {
                            Console.WriteLine("Ugyldigt input. Programmet afsluttes.");
                            return;
                        }
                        Functions.Calculate(num1, num2);
                        break;
                    case "5":
                        Console.Write("Indtast radius af cirklen: ");
                        // Konverterer brugerens input til en positiv double (radius). Hvis både konverteringen lykkes, og radius er større end 0, udføres koden i if-blokken.
                        if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
                        {
                            Functions.CalculateCircle(radius);  // Kalder metoden for at beregne areal og omkreds
                        }
                        else
                        {
                            Console.WriteLine("Ugyldig radius. Prøv igen.");
                        }
                        break;
                    case "6":
                        Console.Write("Indtast det første tal: ");
                        if (!double.TryParse(Console.ReadLine(), out double firstNumber))
                        {
                            Console.WriteLine("Ugyldigt input. Programmet afsluttes.");
                            return;
                        }

                        Console.Write("Indtast det andet tal: ");
                        if (!double.TryParse(Console.ReadLine(), out double secondNumber))
                        {
                            Console.WriteLine("Ugyldigt input. Programmet afsluttes.");
                            return;
                        }

                        Functions.EvaluateExpressions(firstNumber, secondNumber);  // Kalder metoden
                        break;
                    case "exit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        break;
                }
            }
        }
    }
}
