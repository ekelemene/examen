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
            //Создаем список людей и добавляем несколько объектов Person
            List<Person> peopleList = new List<Person>();
            //инициализация
            peopleList.Add(new Person("Иван", 25));
            peopleList.Add(new Person("Анна", 30));
            peopleList.Add(new Person("Борис", 22));
            peopleList.Add(new Person("Елена", 28));

            // Создаем SortedSet (отсортированное множество), передавая в него список людей
            // SortedSet автоматически отсортирует элементы согласно реализации CompareTo
            SortedSet<Person> peopleSet = new SortedSet<Person>(peopleList);

            // Выводим список людей, отсортированный по имени
            Console.WriteLine("Список людей, отсортированный по имени:");
            peopleList.Sort(); // Сортируем список с помощью метода Sort(), который использует CompareTo
            foreach (Person p in peopleList)
            {
                Console.WriteLine(p); // Вызывается метод ToString для красивого вывода
            }

            Console.WriteLine("\nМножество людей, отсортированное по имени:");
            foreach (Person p in peopleSet)// Выводим элементы SortedSet — они уже отсортированы по имени
            {
                Console.WriteLine(p);
            }
        }
    }
}
