using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// класс поинт
    /// </summary>
    class Point
    {
        /// <summary>
        /// поля
        /// </summary>
        private int x, y;
        private string name;

        /// <summary>
        /// конструктор 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="name"></param>
        public Point(int x, int y, string name)
        {
            this.x = x; // присваиваем значение параметра x полю x объекта
            this.y = y;
            this.name = name;//присваиваем имя точки
        }

        /// <summary>
        /// // Свойство для получения координаты X
        /// </summary>
        public int X
        {
            get { return x; }
        }

        /// <summary>
        ///  Свойство для получения координаты Y
        /// </summary>
        public int Y
        {
            get { return y; }
        }
        /// <summary>
        /// // Свойство для получения имени точки
        /// </summary>
        public string Name
        {
            get { return name; }
        }
    }
}
