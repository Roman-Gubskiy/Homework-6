using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task60;
using static System.Net.Mime.MediaTypeNames;

namespace Task60
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте программу в которой создайте класс «Адрес».
    В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс.
    Для каждого поля, создать свойство с двумя методами доступа. Также в классе необходимо
    создать метод для отображения информации про адрес.В методе Main() создайте экземпляр
    класса «Адрес», присвойте всем полям значение через свойства доступа, а также на экземпляр
    класса вызовите метод, который выводит информацию про адрес.*/
    class Address
    {
        
        public string Country // public string Country {get; set;}
        {
            set
            { country = value;} // возможна проверка if и т.д.
            get 
            { return country; } // возрат
        }
        private string country; // доступ

        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Index { get; set; }
        public void PritnAddress()
        {
            Console.WriteLine($"Страна: {Country}");
            Console.WriteLine($"Город: {City}");
            Console.WriteLine($"Улица: {Street}");
            Console.WriteLine($"Дом: {House}");
            Console.WriteLine($"Инлекс: {Index}");
            Console.ReadKey();
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Address jian = new Address();
        jian.Country = "Украина";
        jian.City = "Харьков";
        jian.Street = "П.Шлях";
        jian.House = "133";
        jian.Index = "62433";
        jian.PritnAddress();
        Console.ReadKey();
    }
}
