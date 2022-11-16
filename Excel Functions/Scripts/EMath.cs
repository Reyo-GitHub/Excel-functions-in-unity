using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExcelFunctions.Math
{
    public static class EMath
    {
        //Sum Function
        public static int SUM(int[] numbers)
        {
            int sumtion = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumtion += numbers[i];
            }
            return sumtion;
        }
        public static float SUM(float[] fNumbers)
        {
            float sumtion = 0;
            for (int i = 0; i < fNumbers.Length; i++)
            {
                sumtion += fNumbers[i];
            }
            return sumtion;
        }
        //Average
        public static float Average(int[] numbers)
        {
            return SUM(numbers) / 2;
        }
        public static float Average(float[] fNumbers)
        {
            return SUM(fNumbers) / 2;
        }
        //ABS
        public static int ABS(int number)
        {
            return Mathf.Abs(number);
        }
        public static float ABS(float fNumber)
        {
            return Mathf.Abs(fNumber);
        }
        //EXP
        public static float EXP(float number)
        {
            return Mathf.Exp(number);
        }
        public static float EXP(int fNumber)
        {
            return Mathf.Exp(fNumber);
        }
        //FACT
        public static int FACT(int number)
        {
            number = Mathf.Clamp(number, 1, 10);
            int factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        //SIGN
        public static int SIGN(float number)
        {
            if (number == 0)
            {
                return 0;
            }
            return (int)Mathf.Sign(number);
        }
        //MOD
        public static int MOD(int number, int divisor)
        {
            int quotient = (int)(number / divisor);
            int value = divisor * quotient;
            int result = number - value;
            return result;
        }
        public static float MOD(float number, float divisor)
        {
            int quotient = (int)(number / divisor);
            float value = divisor * quotient;
            float result = number - value;
            return result;
        }
        //ROUND
        public static float ROUND(float number, int num_digits)
        {
            float value = number;
            for (int i = 0; i < Mathf.Abs(num_digits); i++)
            {
                if (num_digits > 0)
                {
                    value *= 10;
                }
                else
                {
                    value /= 10;
                }
            }
            value = Mathf.Round(value);
            for (int i = 0; i < Mathf.Abs(num_digits); i++)
            {
                if (num_digits > 0)
                {
                    value /= 10;
                }
                else
                {
                    value *= 10;
                }
            }
            return value;
        }
        //ROUNDUP
        public static float ROUNDUP(float number, int num_digits)
        {
            float value = number;
            for (int i = 0; i < Mathf.Abs(num_digits); i++)
            {
                if (num_digits > 0)
                {
                    value *= 10;
                }
                else
                {
                    value /= 10;
                }
            }
            value = Mathf.Round(value + 0.5f);
            for (int i = 0; i < Mathf.Abs(num_digits); i++)
            {
                if (num_digits > 0)
                {
                    value /= 10;
                }
                else
                {
                    value *= 10;
                }
            }
            return value;
        }
        //ROUNDDOWN
        public static float ROUNDDOWN(float number, int num_digits)
        {
            float value = number;
            for (int i = 0; i < Mathf.Abs(num_digits); i++)
            {
                if (num_digits > 0)
                {
                    value *= 10;
                }
                else
                {
                    value /= 10;
                }
            }
            value = Mathf.Round(value - 0.5f);
            for (int i = 0; i < Mathf.Abs(num_digits); i++)
            {
                if (num_digits > 0)
                {
                    value /= 10;
                }
                else
                {
                    value *= 10;
                }
            }
            return value;
        }
        //RAND
        public static float RAND()
        {
            return UnityEngine.Random.Range(0f, 1f);
        }
        //RANDBETWEEN
        public static int RANDBETWEEN(int bottom, int top)
        {
            return UnityEngine.Random.Range(bottom, top);
        }
        public static float RANDBETWEEN(float bottom, float top)
        {
            return UnityEngine.Random.Range(bottom, top);
        }
        //POWER
        public static float POWER(float number, float power)
        {
            return Mathf.Pow(number, power);
        }
        //SQRT
        public static float SQRT(float number)
        {
            return Mathf.Sqrt(number);
        }
        //QUOTIENT
        public static int QUOTIENT(float numerator, float denominator)
        {
            return (int)(numerator / denominator);
        }
        //INT
        public static int INT(float number)
        {
            return (int)number;
        }
        //PI
        public const float PI = 3.14159274F;
        //SQRTPI
        public static float SQRTPI(float number)
        {
            return Mathf.Sqrt(number * Mathf.PI);
        }
        //DEGREES
        public static float DEGREES(float angle)
        {
            return angle * Mathf.Rad2Deg;
        }
        //RADIANS
        public static float RADIANS(float angle)
        {
            return angle * Mathf.Deg2Rad;
        }
        //COS
        public static float COS(float number)
        {
            return Mathf.Cos(number);
        }
        //e
        public const float e = 2.7182818285f;
        //COSH
        public static float COSH(float number)
        {
            return ((Mathf.Pow(e, number) + Mathf.Pow(e, -number)) / 2);
        }
        //SEC
        public static float SEC(float number)
        {
            return 1 / Mathf.Cos(number);
        }
        //SECH
        public static float SECH(float number)
        {
            return 1 / COSH(number);
        }
        //SIN
        public static float SIN(float number)
        {
            return Mathf.Sin(number);
        }
        //SINH
        public static float SINH(float number)
        {
            return ((Mathf.Pow(e, number) - Mathf.Pow(e, -number)) / 2);
        }
        //CSC
        public static float CSC(float number)
        {
            return 1 / Mathf.Sin(number);
        }
        //CSCH
        public static float CSCH(float number)
        {
            return 1 / SINH(number);
        }
        //TAN
        public static float TAN(float number)
        {
            return Mathf.Tan(number);
        }
        //TANH
        public static float TANH(float number)
        {
            return (Mathf.Pow(e, number) - Mathf.Pow(e, -number)) / (Mathf.Pow(e, number) + Mathf.Pow(e, -number));
        }
        //COT
        public static float COT(float number)
        {
            return 1 / TAN(number);
        }
        //COTH
        public static float COTH(float number)
        {
            return 1 / TANH(number);
        }
        //ATAN2
        public static float ATAN2(float x_num, float y_num)
        {
            return Mathf.Atan2(y_num, x_num);
        }
        //ATAN
        public static float ATAN(float number)
        {
            return Mathf.Atan(number);
        }
        //ATAN
        public static float ACOT(float number)
        {
            return 1 / ATAN(number);
        }
        //ACOS
        public static float ACOS(float number)
        {
            return Mathf.Acos(number);
        }
        //ASIN
        public static float ASIN(float number)
        {
            return Mathf.Asin(number);
        }
        //LCM
        private static int lcmB2numbers(int num1, int num2)
        {
            int x = num1;
            int y = num2;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            return ((x * y) / num1);
        }
        public static int LCM(int[] numbers)
        {
            int result = 0;
            result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result = lcmB2numbers(result, numbers[i]);
            }
            return result;
        }
        //GCD
        private static int gcdB2numbers(int num1, int num2)
        {
            return ((num1 * num2) / lcmB2numbers(num1, num2));
        }
        public static int GCD(int[] numbers)
        {
            int result = 0;
            result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result = gcdB2numbers(result, numbers[i]);
            }
            return result;
        }
    }
}