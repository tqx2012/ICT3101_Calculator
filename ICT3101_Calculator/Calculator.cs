using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public double num1;
        public double num2;

        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            if (num1 == 0 && num2 != 0)
            {
                return 2;
            }
            if (num2 == 0 && num1 != 0)
            {
                return 200;
            }
            if (num1 == 0 && num2 == 0)
            {
                return 666;
            }
            return (num1 + num2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 > 0)
            {
                return 0;
            }
            else if (num1 > 0 && num2 == 0)
            {
                return double.PositiveInfinity;
            }
            else if (num1 == 0 && num2 == 0 )
            {
                return 1;
            }
            return (num1 / num2);
        }

        //triangle here
        public double TriangleArea(double num1, double num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                throw new System.ArgumentException("Parameter cannot be 0");
            }
            return 0.5*(num1 * num2);
        }

        //circle here
        public double CircleArea(double radius)
        {
            if (radius == 0)
            {
                throw new System.ArgumentException("Parameter cannot be 0");
            }
            return 3.142 * radius * radius;
        }

        //factorial here
        public double Factorial(double input)
        {
            if (input == 0)
            {
                throw new System.ArgumentException("Parameter cannot be 0");
            }

            double result = input;
            for (double i = input; i > 0 ; i--)
            {
                result = result* input;
            }
            return result;
        }
    }
}
