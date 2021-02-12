using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractions
{
    class Fraction
    {
        double real;
        double imag;
        public Fraction(double realNumber, double imagineNumber)
        {
            real = realNumber;
            imag = imagineNumber;
        }

        public static Fraction Parse(string stringToParse)
        {
            double firstNumber, secondNumber;
            char symbol = '+';

            string[] stringToParseArray = stringToParse.Split(' ');
            try
            {
                if (stringToParseArray[1] == "-") symbol = '-';
                else symbol = '+';

                stringToParseArray[0] = stringToParseArray[0].Replace('.', ',');
                stringToParseArray[2] = stringToParseArray[2].Replace('.', ',');

                string firstNumberStr = stringToParseArray[0];
                string[] fnCheck = firstNumberStr.Split('/');
                if (fnCheck.Length > 1) firstNumber = double.Parse(fnCheck[0]) / double.Parse(fnCheck[1]);
                else firstNumber = double.Parse(firstNumberStr);

                string secondNumberStr = stringToParseArray[2];
                string[] snCheck = secondNumberStr.Split('/');
                if (snCheck.Length > 1) secondNumber = double.Parse(snCheck[0]) / double.Parse(snCheck[1]);
                else secondNumber = double.Parse(secondNumberStr);

                if (symbol == '-') secondNumber *= -1;

                return new Fraction(firstNumber, secondNumber);
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода!\nПридерживайтесь формата ±a ± b (Пробелы обязательны)\nВарианты:\n -3.5 + 8\n-21/6 + 8\n-3,5 + 8\n3.5 - -3/-5", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new Fraction(0, 0);
            }
        }

        public override string ToString()
        {
            if (imag == 0) return $"{real}";
            else if (real == 0) return $"{imag} i";

            if (imag < 0)
            {
                imag *= -1;
                return $"{real} - {imag} i";
            }
            return $"{real} + {imag} i";
        }

        public Fraction Round(int numbers) => new Fraction(Math.Round(real, numbers), Math.Round(imag, numbers));

        public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a.real + b.real, a.imag + b.imag);
        public static Fraction operator -(Fraction a, Fraction b) => new Fraction(a.real - b.real, a.imag - b.imag);
        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.real * b.real + (a.imag * b.imag) * -1, a.imag * b.real + a.real * b.imag);
        public static Fraction operator /(Fraction a, Fraction b) => new Fraction(
            (a.real * b.real + a.imag * b.imag) / (Math.Pow(b.real, 2) + Math.Pow(b.imag, 2)),
            (b.real * a.imag - a.real * b.imag) / (Math.Pow(b.real, 2) + Math.Pow(b.imag, 2))
            );
    }
}
