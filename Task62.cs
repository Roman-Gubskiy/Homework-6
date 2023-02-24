using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task62
{
    /*Условие:
    Используя Visual Studio, создайте проект по шаблону Console Application. 
    Создайте программу в которой создайте класс «Банковский Счет».
    В теле класса создайте следующие поля: дата открытия счета, процентная ставка по счету, 
    сумма счета. В теле класса создайте следующие методы:

    -Метод, который рассчитывает количество дней, начиная с даты открытия счета;
    -Метод который выводит информацию о количестве рассчитанных дней;
    -Метод который рассчитывает сумму, которая будет на счете через определенное 
    количество лет (количество лет – параметр метода); 
    -Метод который выводит информацию о сумме.

    Также продумать над конструктором класса. В методе Main() 
    создайте экземпляр класса «Банковский Счет», присвойте всем полям значение через свойства 
    доступа, а также на экземпляр класса вызовите методы для отображения количества дней и 
    суммы.*/
    class BankOperations
    {
        public string AccountEndDate { get; set; }       // дата открытия счета 
        public double AccountInterestRate { get; set; }     // процентная ставка по счету
        public int AccountAmount { get; set; }           // сумма счета

        public void AmountOfDays2(string AccountEndDate)
        {
            DateTime start = DateTime.Parse(AccountEndDate);
            DateTime end = DateTime.Parse("24.02.2024");
            var a = (end - start).TotalDays;
            Console.WriteLine(a);
        }
        public static double AmountOfDays(string datestart)
        {
            string dateEnd = "24.02.2024";
            DateTime start = DateTime.Parse(datestart);
            DateTime end = DateTime.Parse(dateEnd);
            return (end - start).TotalDays;

            //(ДЛЯ СЕБЯ)
            //Авто день начала открытия 
            //string dateNow = DateTime.Now.ToString("dd.MM.yyyy");
            //DateTime start = DateTime.Parse(dateNow);
            //DateTime end = DateTime.Parse(date);
            //return (end - start).TotalDays;
        }
        public double AmountOfDays3(string datestart, double interestСost, double income)
        {
            double days = BankOperations.AmountOfDays(datestart);
            int days2 = (int)days;
            //int month = days2 / 30; // месяцев в периоде дней
            //double interestСost = 1000, income = 0.04, х = 100, sum, interestIncome = 0;
            double х = 100, sum, interestIncome = 0;
            for (int i = 1; i <= days2; i++)
            {
                sum = (interestСost * income / х);
                interestСost += sum; // сумма вклада с %
                interestIncome += sum; // чистые % на все указанные дни в периоде
                //Console.WriteLine($"мес {i}");
            }
            return Math.Round(interestСost, 2);// 2 цифры после запятой
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankOperations bank = new BankOperations();
            bank.AccountEndDate = "24.02.2023";
            bank.AccountInterestRate = 0.04;
            bank.AccountAmount = 1000;
            // Метод который выводит информацию о количестве рассчитанных дней;            
            bank.AmountOfDays2(bank.AccountEndDate);
            // Метод, который рассчитывает количество дней, начиная с даты открытия счета;
            Console.WriteLine(BankOperations.AmountOfDays("24.02.2023"));
            // -Метод который рассчитывает сумму, которая будет на счете через определенное 
            //  количество лет(количество лет – параметр метода);
            Console.WriteLine(bank.AmountOfDays3(bank.AccountEndDate, bank.AccountAmount, bank.AccountInterestRate));

        }
    }
}