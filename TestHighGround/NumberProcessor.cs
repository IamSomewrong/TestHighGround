using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHighGround
{
    public static class NumberProcessor
    {
        // Метод, преобразовывающий массив строк в единую строку для вывода 
        public static string PrepareForPrint(string[] numbers)
        {
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
                if (i < numbers.Length - 1)
                    result += ", ";
            }
            return result;
        }

        // Метод для выполнения первой части задания
        public static string ProcessNumberFirst(string number)
        {
            int _number = Convert.ToInt32(number);
            string result = "";

            if (_number % 3 == 0)
            {
                result += "fizz-";
            }
            if (_number % 5 == 0)
            {
                result += "buzz-";
            }

            if (result.Length > 0)
                return result.Trim('-');
            else
                return number;
        }

        // Метод для ввыполнения второй части задания
        public static string ProcessNumberSecond(string number)
        {
            int _number = Convert.ToInt32(number);
            string result = "";

            if (_number % 3 == 0)
            {
                result += "fizz-";
            }
            if (_number % 5 == 0)
            {
                result += "buzz-";
            }
            if (_number % 4 == 0)
            {
                result += "muzz-";
            }
            if (_number % 7 == 0)
            {
                result += "guzz-";
            }

            if (result.Length > 0)
                return result.Trim('-');
            else
                return number;
        }

        // Метод для выполнения третьей части задания
        public static string ProcessNumberThird(string number)
        {
            int _number = Convert.ToInt32(number);
            string result = "";

            if (_number % 3 == 0 && _number % 5 == 0)
            {
                result += "good-boy-";
            }
            else if (_number % 3 == 0)
            {
                result += "dog-";
            }
            else if (_number % 5 == 0)
            {
                result += "cat-";
            }

            if (_number % 4 == 0)
            {
                result += "muzz-";
            }
            if (_number % 7 == 0)
            {
                result += "guzz-";
            }

            if (result.Length > 0)
                return result.Trim('-');
            else
                return number;
        }
    }
}
