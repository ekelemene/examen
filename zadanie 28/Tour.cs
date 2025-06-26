using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// класс тур
    /// </summary>
    class Tour
    {
        /// <summary>
        /// Метод без параметров — тур по Минскому морю, бесплатный
        /// </summary>
        /// <returns></returns>
        public double TourCalc()
        {
            Console.WriteLine("Тур: Минское море, бесплатно");
            return 0; // Возвращаем стоимость — 0, так как бесплатно
        }

        /// <summary>
        /// Перегруженный метод с одним параметром — страна тура
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public double TourCalc(string country)
        {
            double cost = 50; // Фиксированная стоимость тура на 1 день
            Console.WriteLine("Тур: " + country + ", 1 день, стоимость: " + String.Format("{0:F2}", cost));
            return cost; // Возвращаем стоимость тура
        }

        /// <summary>
        /// Еще одна перегрузка с двумя параметрами — страна и количество дней
        /// </summary>
        /// <param name="country"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        public double TourCalc(string country, int days)
        {
            double cost = 50 * days; // Стоимость зависит от количества дней (50 за день)
            Console.WriteLine("Тур: " + country + ", " + days + " дней, стоимость: " + String.Format("{0:F2}", cost));
            return cost; // Возвращаем общую стоимость
        } 
    }
}
