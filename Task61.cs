using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task61
{
    /*Условие:
    Используя Visual Studio, создайте проект по шаблону Console Application. 
    Создайте программу в которой создайте класс «Котенок».
    В теле класса создайте следующие поля: имя, возраст, цвет шерсти, цвет глаз. Для каждого 
    поля, создать свойство с двумя методами доступа. Также в теле класса создайте метод, который 
    будет выводить на консоль «Мяу», метод должен принимать один аргумент – количество «Мяу» 
    котенка, выводить «Мяу» соответствующее количество раз. В методе Main() создайте экземпляр 
    класса «Котенок», присвойте всем полям значение через свойства доступа, а также вызовите 
    метод с помощью которого котенок говорит «Мяу», в качестве аргумента метода передайте 3.*/
    class Cat
    {

        public string Name // public string Country {get; set;}
        {
            set
            { name = value; } // возможна проверка if и т.д.
            get
            { return name; } // возрат
        }
        private string name; // имя
        public int Age { get; set; } // возраст
        public string Coat { get; set; } // шерсть
        public string Color { get; set; } // цвет
        public string EyeColor { get; set; } // цвет глаз

        public void PritCatData()
        {
            Console.WriteLine($"Имя:       {Name}");
            Console.WriteLine($"Возраст:   {Age}");
            Console.WriteLine($"Шерсть:    {Coat}");
            Console.WriteLine($"Цвет:      {Color}");
            Console.WriteLine($"Цвет глаз: {EyeColor}");
        }
        public void MyaoCat(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Мяу!!!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat MyCat = new Cat();
            MyCat.Name = "Сникерс";
            MyCat.Age = 6;
            MyCat.Coat = "Короткая";
            MyCat.Color = "Серый";
            MyCat.EyeColor = "Голубой";

            MyCat.PritCatData(); // вывод медода класса Кот

            MyCat.MyaoCat(3); // вывод медода класса Кот - Мяу!!!
            Console.ReadKey();
        }
    }
}
