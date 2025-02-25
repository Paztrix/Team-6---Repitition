using System.ComponentModel.Design;

namespace Repitition_Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program opgaver = new Program();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Vælg en opgave!:");
                Console.WriteLine("1. Information om studerende");
                Console.WriteLine("2. Convertering af Celsius og Fahrenheit");
                Console.WriteLine("3. Udregning af BMI");
                Console.WriteLine("4. Aritmetiske operationer");
                Console.WriteLine("5. Udregning af areal og omkreds");
                Console.WriteLine("6. Logiske operationer");
                Console.WriteLine("7. Tjek tallet");
                Console.WriteLine("8. Tjek karakteren, bestået eller ikke bestået");
                Console.WriteLine("9. Tjek skudår");
                Console.WriteLine("10. Tjek dag");
                Console.WriteLine("11. Tjek måned");
                Console.WriteLine("12. Tæller 1-10 med for-loop");
                Console.WriteLine("13. Tæller 1-10 med while-loop");
                Console.WriteLine("14. Tæller 1-10 med do-while-loop");
                Console.WriteLine("15. Beregner summen af alle tal");
                Console.WriteLine("16. Beregn fakultet");
                Console.WriteLine("Indtast valg: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        opgaver.Opgave1();
                        break;
                    case "2":
                        opgaver.Opgave2();
                        break;
                    case "3":
                        Console.Write("indtast vægt i kilo: ");
                        double userweight = Convert.ToDouble(Console.ReadLine());
                        Console.Write("indtast højde i meter: ");
                        double Userheight = Convert.ToDouble(Console.ReadLine());
                        opgaver.Opgave3(userweight, Userheight);
                        break;
                    case "4":
                        Console.WriteLine("indtast 2 tal!");
                        Console.Write("Tal 1: ");
                        double usernum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tal 2: ");
                        double usernum2 = Convert.ToDouble(Console.ReadLine());
                        opgaver.Opgave4(usernum1, usernum2);
                        break;
                    case "5":
                        Console.Write("indtast en radius: ");
                        double userradius = Convert.ToDouble(Console.ReadLine());
                        opgaver.Opgave5(userradius);
                        break;
                    case "6":
                        Console.WriteLine("indtast 2 integers!");
                        Console.Write("Integer 1: ");
                        int opg6userint1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Integer 2: ");
                        int opg6userint2 = Convert.ToInt32(Console.ReadLine());
                        opgaver.Opgave6(opg6userint1, opg6userint2);
                        break;
                    case "7":
                        Console.Write("Indtast et tal: ");
                        int opg7userint = Convert.ToInt32(Console.ReadLine());
                        opgaver.Opgave7(opg7userint);
                        break;
                    case "8":
                        Console.Write("Indtast din karakter: ");
                        char opg8karakter = Console.ReadLine()[0];
                        opgaver.Opgave8(opg8karakter);
                        break;
                    case "9":
                        Console.Write("Indtast årstal: ");
                        int opg9useryear = Convert.ToInt32(Console.ReadLine());
                        if (opgaver.Opgave9(opg9useryear))
                        {
                            Console.WriteLine($"{opg9useryear} er skudår!");
                        } else
                        {
                            Console.WriteLine($"{opg9useryear} er ikke skudår!");
                        }
                        break;
                    case "10":
                        Console.Write("Indtast et tal mellem 1-7: ");
                        int opg10int = Convert.ToInt32(Console.ReadLine());
                        opgaver.Opgave10(opg10int);
                        break;
                    case "11":
                        Console.Write("Indtast et tal mellem 1-12: ");
                        int opg11int = Convert.ToInt32(Console.ReadLine());
                        opgaver.Opgave11(opg11int);
                        break;
                    case "12":
                        opgaver.Opgave12();
                        break;
                    case "13":
                        opgaver.Opgave13();
                        break;
                    case "14":
                        opgaver.Opgave14();
                        break;
                    case "15":
                        Console.Write("Indtast et tal: ");
                        int opg15int = Convert.ToInt32(Console.ReadLine());
                        opgaver.Opgave15(opg15int);
                        break;
                    case "16":
                        Console.Write("Indtast et tal: ");
                        int opg16int = Convert.ToInt32(Console.ReadLine());
                        opgaver.Opgave16(opg16int);
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen!");
                        break;
                }
            }
        }
        void Opgave1()
        {
            int age = 25;
            float height = 1.75f;
            double weight = 70.5d;
            char initial = 'A';
            string name = "Alice";
            bool IsStudent = true;

            Console.WriteLine($"Alder: {age}, Højde: {height}, Vægt: {weight}, Initial: {initial}, Navn: {name}, Er studerende: {IsStudent}");
        }
        void Opgave2()
        {
            double Celsius = 25d;
            double Fahrenheit = 77d;

            Celsius = (Fahrenheit - 32) * (5.0 / 9.0);
            Fahrenheit = Celsius * (9.0 / 5.0) + 32;

            Console.WriteLine($"{Celsius}C er {Fahrenheit}F");
            Console.WriteLine($"{Fahrenheit}F er {Celsius}C");
        }
        void Opgave3(double userweight, double userheight)
        {
            double BMI = userweight / Math.Pow(userheight, 2);
            Console.WriteLine($"BMI: {BMI}");
        }
        void Opgave4(double usernum1, double usernum2)
        {
            double Sum = usernum1 + usernum2;
            double Difference = usernum1 - usernum2;
            double Product = usernum1 * usernum2;
            double Quotient = usernum1 / usernum2;
            double Remainder = usernum1 % usernum2;

            Console.WriteLine($"Sum: {Sum}, Difference: {Difference}, Product: {Product}, Kvotient: {Quotient}, Rest: {Remainder}");
        }
        void Opgave5(double userradius)
        {
            double Area = double.Pi * Math.Pow(userradius,2);
            double Circumference = 2 * double.Pi * userradius;

            Console.WriteLine($"Areal: {Area}, Omkreds: {Circumference}");
        }
        void Opgave6(int opg6userint1, int opg6userint2)
        {
            bool IsEqual = opg6userint1 == opg6userint2;
            bool IsNotEqual = opg6userint1 != opg6userint2;
            bool IsGreater = opg6userint1 > opg6userint2;
            bool IsLess = opg6userint1 < opg6userint2;
            bool IsGreaterOrEqual = opg6userint1 >= opg6userint2;
            bool IsLessOrEqual = opg6userint1 <= opg6userint2;

            Console.WriteLine($"Is Equal: {IsEqual}, Is Not Equal: {IsNotEqual}, Is Greater: {IsGreater}, Is Less: {IsLess}, Is Greater Or Equal: {IsGreaterOrEqual}, Is Less Or Equal: {IsLessOrEqual}");
        }
        void Opgave7(int opg7userint)
        {
            if (opg7userint > 0)
            {
                Console.WriteLine("Tallet er positivt!");
            }
            else if (opg7userint < 0)
            {
                Console.WriteLine("Tallet er negativt");
            }
            else if (opg7userint == 0) {
                Console.WriteLine("Tallet er 0");
            }
        }
        void Opgave8(char opg8karakter)
        {
            if (opg8karakter == 'A')
            {
                Console.WriteLine("Bestået!");
            } else if (opg8karakter == 'B') {
                Console.WriteLine("Bestået!");
            } else if (opg8karakter == 'C')
            {
                Console.WriteLine("Bestået!");
            } else if (opg8karakter == 'D')
            {
                Console.WriteLine("Bestået!");
            } else if (opg8karakter == 'F')
            {
                Console.WriteLine("Ikke bestået!");
            }
        }
        bool Opgave9(int opg9useryear)
        {
            if (opg9useryear % 4 == 0)
            {
                if (opg9useryear % 100 == 0)
                {
                    if (opg9useryear % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
        void Opgave10(int opg10int)
        {
            switch(opg10int)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;
                case 2:
                    Console.WriteLine("Tirsdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lørdag");
                    break;
                case 7:
                    Console.WriteLine("Søndag");
                    break;
            }
        }
        void Opgave11(int opg11int)
        {
            switch (opg11int)
            {
                case 1:
                    Console.WriteLine("Januar: Årets første måned, ofte kold og med sne i mange lande. Navnet kommer fra den romerske gud Janus, der havde to ansigter – et der så fremad, og et der så tilbage.");
                    break;
                case 2:
                    Console.WriteLine("Februar: Den korteste måned, kendt for fastelavn og valentinsdag. Navnet kommer fra det latinske ord \"februa\", der betyder renselse.");
                    break;
                case 3:
                    Console.WriteLine("Marts: Forårets komme begynder så småt. Navnet kommer fra den romerske krigsgud Mars.");
                    break;
                case 4:
                    Console.WriteLine("April: Kendt for påske og for at være en måned med omskifteligt vejr. Navnet kommer fra det latinske ord \"aperire\", der betyder at åbne (blomsterne springer ud).");
                    break;
                case 5:
                    Console.WriteLine("Maj: Foråret er i fuld gang, og naturen blomstrer. Navnet kommer fra den romerske gudinde Maia.");
                    break;
                case 6:
                    Console.WriteLine("Juni: Sommerens begyndelse, ofte med varmt vejr og lange dage. Navnet kommer fra den romerske gudinde Juno.");
                    break;
                case 7:
                    Console.WriteLine("Juli: Højsommer, mange holder ferie. Navnet kommer fra Julius Cæsar.");
                    break;
                case 8:
                    Console.WriteLine("August: Stadig sommer, men dagene begynder at blive kortere. Navnet kommer fra kejser Augustus.");
                    break;
                case 9:
                    Console.WriteLine("September: Efterårets begyndelse, bladene begynder at skifte farve. Navnet kommer fra det latinske ord \"septem\", der betyder syv (september var den syvende måned i den gamle romerske kalender).");
                    break;
                case 10:
                    Console.WriteLine("Oktober: Efteråret er i fuld gang, og det kan være blæsende og regnfuldt. Navnet kommer fra det latinske ord \"octo\", der betyder otte.");
                    break;
                case 11:
                    Console.WriteLine("November: En mørk og ofte trist måned, hvor mange tænker på de døde. Navnet kommer fra det latinske ord \"novem\", der betyder ni.");
                    break;
                case 12:
                    Console.WriteLine("December: Årets sidste måned, kendt for jul og nytår. Navnet kommer fra det latinske ord \"decem\", der betyder ti.");
                    break;
            }
        }
        void Opgave12()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        void Opgave13()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i++);
            }
        }
        void Opgave14()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }
        void Opgave15(int opg15int)
        {
            int sum = 0;

            for (int i = 1; i <= opg15int; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Summen af alle tal fra 1 til {opg15int} er {sum}");
        }
        void Opgave16(int opg16int)
        {
            int factorial = 1;

            for (int i = 1; i <= opg16int; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Fakultet af {opg16int} er: {factorial}");
        }
    }
}