using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Person представляет человека с именем и возрастом
    /// </summary>
    class Person : IComparable
    {
        /// <summary>
        /// Приватные поля для хранения имени и возраста
        /// </summary>
        private string name;
        private int age;

        /// <summary>
        /// Свойство для доступа к имени
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Свойство для доступа к возрасту
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Конструктор класса, инициализирует имя и возраст
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        /// <summary>
        /// Реализация метода CompareTo интерфейса IComparable
        /// Позволяет сравнивать текущий объект Person с другим объектом
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object obj)
        {
            // Приведение переданного объекта к типу Person
            Person other = obj as Person;
            // Если приведение не удалось, выбрасываем исключение
            if (other == null)
            {
                throw new ArgumentException("Объект не является Person");
            }
            // Сравниваем имена двух Person лексикографически
            // Возвращаем отрицательное число, если текущий меньше другого,
            // 0 если равны, и положительное если больше
            return name.CompareTo(other.name);
        }

        /// <summary>
        /// Переопределение метода ToString для удобного вывода информации о человеке
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Имя: " + name + ", Возраст: " + age;
        }
    }
}
