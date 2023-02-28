using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task64
{
    /*Условие:
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте программу, в которой создайте класс «Точка» – для описания координат  точки на 
    координатной прямой рис №1. В теле класса создайте следующие закрытые поля: целочисленное 
    поле для описания координаты точки X и целочисленное поле для описания координаты точки 
    Y, а также строковое поле для имени точки. Создать три свойства с методами доступа get и 
    set, а также конструктор класса, который будет инициализировать данные поля значениями 
    аргументов. Далее создайте класс «Фигура». В теле класса фигура создайте одно поле типа масив 
    «Точек» и одно строкове поле для имени фигуры и 2 конструктора, которые принимают 3
    (треугольника) и 4 аргумента (четырехугольника). В теле класса «Фигура» создайте два метода: 
    1-й для расчета длины стороны фигуры, метод должен принимать 2 аргумента типа «Точка» и
    возвращать длину стороны, формула для расчета 𝑑 = √(𝑥2 − 𝑥1)2 + (𝑦2 − 𝑦1)2   
    2-й метод для расчета периметра фигуры (подсказка – в методе циклом перебирать массив «Точек»,
    пока в нем будут элементы, и рассчитывать длину стороны). В методе Main() создать и рассчитать 
    периметр треугольника, квадрата, прямоугольника, точки выбрать произвольные.*/

    class Dot
    {
        private int dotX;
        public int DotX // Поле класса
        {
            set { dotX = value; }
            get { return dotX; }
        }
        private int dotY;
        public int DotY // Поле класса
        {
            set { dotY = value; }
            get { return dotY; }
        }
        private string nameDot;
        public string NameDot // Поле класса
        {
            set { nameDot = value; }
            get { return nameDot; }
        }
        public Dot(int newdotX, int newdotY, string newnameDot) // Конструктор перегрузка 1
        {   
            dotX = newdotX;
            dotY = newdotY;
            nameDot = newnameDot;
        }
        public Dot(int newdotX) // Конструктор перегрузка 2
        {
            dotX = newdotX;
        }
      }
    class Figure
    {
        private Dot a; 
        public Dot A // Поле класса
        {
            set { a = value; }
            get { return a; }
        }
        private Dot b;
        public Dot B // Поле класса
        {
            set { b = value; }
            get { return b; }
        }
        private Dot[] arrayDot; 
        public Dot[] ArrayDot // Поле класса
        {
            set { arrayDot = value; }
            get { return arrayDot; }
        }
        private string nameFigure;
        public string NameFigure // Поле класса
        {
            set { nameFigure = value; }
            get { return nameFigure; }
        }
        public Figure(Dot[] newarrayDot) // Конструктор
        {
            arrayDot = newarrayDot;
        }
        public Figure(Dot newA) // Конструктор перегрузка 1
        {
            a = newA;
        }
        public Figure(Dot newA, Dot newB) // Конструктор перегрузка 2
        {
            a = newA;
            b = newB;
        }
        public void SideLength(Dot a, Dot b) // Метод расчета длины стороны фигуры по 2 точкам
        {
            int x1 = a.DotX, y1 = a.DotY, x2 = b.DotX, y2 = b.DotY;
            string c1 = a.NameDot, c2 = b.NameDot;
            double P = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(P);
            Console.WriteLine($"Расчет длины стороны фигуры точек: {c1}({x1},{y1}) и {c2}({x2},{y2})");
            Console.WriteLine($"Равен: {Math.Round(result, 2)}");
        }        
        public void ArrayFig(Dot[] jianArray) // Метод под массив для перебора точек 
        {            
            for (int i = 0; i < jianArray.Length; i++)
            {                
                Dot result = jianArray[i]; // Перебор с конвертацией и суммированием
                sum += ConverDot(result);
            }
            if (jianArray.Length == 4) // 1-й вывод
            {
                Console.WriteLine($"Перимет квадрата - прямоугольника: {sum}");
            }
            if (jianArray.Length == 3) // 2-й вывод
            {
                Console.WriteLine($"Перимет треугольника: {sum}");
            }
        }
        double sum = 0;
        public double ConverDot(Dot a) // Метод конверта точек Dot в double
        {
            double result = a.DotX;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dot DotA = new Dot(3,7,"A");
            Dot DotB = new Dot(-2,15,"B");
            Figure jian = new Figure(DotA, DotB);
            // 1-й для расчета длины стороны фигуры, метод должен принимать 2 аргумента типа «Точка»
            jian.SideLength(DotA, DotB);
            
            // 2-й метод для расчета периметра фигуры
            Dot DotX1 = new Dot(4); //jianArray[0] = new Dot(4);
            Dot DotX2 = new Dot(5); //jianArray[1] = new Dot(5);
            Dot DotX3 = new Dot(2); //jianArray[2] = new Dot(2);
            Dot DotX4 = new Dot(8); //jianArray[3] = new Dot(8);
            Dot[] jianArray = new Dot[] { DotX1, DotX2, DotX3, DotX4 };         
            jian.ArrayFig(jianArray);
        }
    }
}
