using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс для конвертации валют между BYN 
    /// </summary>
    class Converter
    {
        /// <summary>
        /// поля  курс валют
        /// </summary>
        private double usdRate, eurRate, rubRate;

        /// <summary>
        /// Конструктор, инициализирует курсы валют
        /// </summary>
        /// <param name="usd"></param>
        /// <param name="eur"></param>
        /// <param name="rub"></param>
        public Converter(double usd, double eur, double rub)
        {
            usdRate = usd;
            eurRate = eur;
            rubRate = rub;
        }

        /// <summary>
        ///  Конвертация BYN в USD (делим сумму в BYN на курс USD)
        /// </summary>
        /// <param name="byn"></param>
        /// <returns></returns>
        public double ConvertBYNtoUSD(double byn)
        {
            return byn / usdRate;
        }

        /// <summary>
        /// Конвертация BYN в EUR
        /// </summary>
        /// <param name="byn"></param>
        /// <returns></returns>
        public double ConvertBYNtoEUR(double byn)
        {
            return byn / eurRate;
        }

        /// <summary>
        /// Конвертация BYN в RUB
        /// </summary>
        /// <param name="byn"></param>
        /// <returns></returns>
        public double ConvertBYNtoRUB(double byn)
        {
            return byn / rubRate;
        }

        /// <summary>
        /// Конвертация USD в BYN (умножаем сумму USD на курс USD)
        /// </summary>
        /// <param name="usd"></param>
        /// <returns></returns>
        public double ConvertUSDtoBYN(double usd)
        {
            return usd * usdRate;
        }

        /// <summary>
        /// Конвертация EUR в BYN
        /// </summary>
        /// <param name="eur"></param>
        /// <returns></returns>
        public double ConvertEURtoBYN(double eur)
        {
            return eur * eurRate;
        }

        /// <summary>
        /// Конвертация RUB в BYN
        /// </summary>
        /// <param name="rub"></param>
        /// <returns></returns>
        public double ConvertRUBtoBYN(double rub)
        {
            return rub * rubRate;
        }
    }
}
