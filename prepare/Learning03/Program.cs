using System;

class Program
 {
        static void Main(string[] args)
        {
            // Creating instances of the Fraction class using different constructors
            Fraction fraction1 = new Fraction(); // Default constructor (1/1)
            Fraction fraction2 = new Fraction(6); // Constructor with one parameter (6/1)
            Fraction fraction3 = new Fraction(3, 4); // Constructor with two parameters (3/4)
            Fraction fraction4 = new Fraction(1, 3); // Constructor with two parameters (1/3)

            // Displaying the fractions and their decimal values
            Console.WriteLine(fraction1.GetFractionString()); // Outputs: 1/1
            Console.WriteLine(fraction1.GetDecimalValue()); // Outputs: 1.0

            Console.WriteLine(fraction2.GetFractionString()); // Outputs: 6/1
            Console.WriteLine(fraction2.GetDecimalValue()); // Outputs: 6.0

            Console.WriteLine(fraction3.GetFractionString()); // Outputs: 3/4
            Console.WriteLine(fraction3.GetDecimalValue()); // Outputs: 0.75

            Console.WriteLine(fraction4.GetFractionString()); // Outputs: 1/3
            Console.WriteLine(fraction4.GetDecimalValue()); // Outputs: 0.3333333333333333

            // You can also modify fractions using setters if needed
            fraction2.SetNumerator(5); // Changing the numerator to 5
            fraction2.SetDenominator(2); // Changing the denominator to 2
            Console.WriteLine(fraction2.GetFractionString()); // Outputs: 5/2
            Console.WriteLine(fraction2.GetDecimalValue()); // Outputs: 2.5
        }
    }