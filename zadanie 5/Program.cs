using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём объект Converter с заданными курсами валют к BYN
            Converter converter = new Converter(2.5, 3.0, 0.035);

            //Запрашиваем у пользователя сумму в BYN для конвертации
            Console.Write("Введите сумму в BYN: ");
            double byn = Convert.ToDouble(Console.ReadLine());
            // Конвертируем введённую сумму BYN в USD, EUR и RUB и выводим результат с двумя знаками после запятой
            Console.WriteLine($"BYN в USD: {converter.ConvertBYNtoUSD(byn):F2}");
            Console.WriteLine($"BYN в EUR: {converter.ConvertBYNtoEUR(byn):F2}");
            Console.WriteLine($"BYN в RUB: {converter.ConvertBYNtoRUB(byn):F2}");

            // Запрашиваем у пользователя сумму в USD для конвертации в BYN
            Console.Write("Введите сумму в USD: ");
            double usd = Convert.ToDouble(Console.ReadLine());
            // Конвертируем USD в BYN и выводим результат
            Console.WriteLine($"USD в BYN: {converter.ConvertUSDtoBYN(usd):F2}");

            // Запрашиваем сумму в EUR для конвертации в BYN
            Console.Write("Введите сумму в EUR: ");
            double eur = Convert.ToDouble(Console.ReadLine());
            // Конвертируем EUR в BYN и выводим результат
            Console.WriteLine($"EUR в BYN: {converter.ConvertEURtoBYN(eur):F2}");

            // Запрашиваем сумму в RUB для конвертации в BYN
            Console.Write("Введите сумму в RUB: ");
            double rub = Convert.ToDouble(Console.ReadLine());
            // Конвертируем RUB в BYN и выводим результат
            Console.WriteLine($"RUB в BYN: {converter.ConvertRUBtoBYN(rub):F2}");
        }
    }
}
