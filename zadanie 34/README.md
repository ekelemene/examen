Задание 34. Используя Visual Studio, создайте проект по шаблону Console Application.
1.	Создайте интерфейсы IInterface1, IInterface2, IInterface3.
2.	Интерфейс IInterface2 наследуйте от интерфейса IInterface1.
3.	Интерфейс IInterface3 наследуйте от интерфейса IInterface2.
4.	В каждом интерфейсе создайте по одному методу с соответствующими именами: Method1(), Method2(), Method3().
5.	Создайте производный класс DerivedClass, который наследуется от интерфейса IInterface3.
6.	В классе DerivedClass реализуйте все три метода Method1(), Method2(), Method3().
7.	В методе Main() создайте объект dClass и вызовите все методы, чтобы в консольном окне был выведен следующий текст:
Метод Method1
Метод Method2
Метод Method3
