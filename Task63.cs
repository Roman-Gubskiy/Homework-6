using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task63
{
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону Console Application.
        Создайте программу, в которой создайте класс «Треугольник». В теле класса создайте три
        закрытых поля для описания сторон треугольника и три свойства для чтения и записи. Также в
        теле класса создайте 3 метода: 
          1-й для расчета площади треугольника, формула для расчета 𝑆 = √𝑝 ∗ (𝑝 − 𝑎) ∗ (𝑝 − 𝑏) ∗ (𝑝 − 𝑐), 
        где 𝑝 - полупериметр треугольника 𝑝 = (𝑎 + 𝑏 + 𝑐) / 2, a, b, c – длины сторон треугольника,
          2-й для расчета периметра треугольника, формула для расчета 𝑝 = (𝑎 + 𝑏 + 𝑐)/2,
          3-й для вывода информации о площади и периметре треугольника.
        Создайте конструктор, который в качестве аргументов приминимает стороны треугольника и инициализирует поля класса.
        В методе Main() создайте экземпляр класса «Треугольник», задайте произвольное значение сторон 
        треугольника и выведите на экран значение периметра и площади треугольника.*/

    class Triangle
    {
        private double sideA;
        public double SideA // { get; set; }
        {
            set
            { sideA = value; }
            get
            { return sideA; }
        }
        private double sideB;
        public double SideB
        {
            set
            { sideB = value; }
            get
            { return sideB; }
        }
        private double sideC;
        public double SideC
        {
            set
            { sideC = value; }
            get
            { return sideC; }
        }
        public Triangle(double newsideA, double newsideB, double newsideC)
        {   // Конструктор
            sideA = newsideA;
            sideB = newsideB;
            sideC = newsideC;
        }
        public double AreaOfTriangle(double a, double b, double c)
        {   //Расчет площади треугольника
            double p = (a + b +c) / 2;
            double S = (p * (p - a) * (p - b) * (p - c));
            double S2 = Math.Sqrt(S);
            return S2;
        }
        public void AreaOfTriangle2()
        {   //Расчет площади треугольника
            double p = (SideA + SideB + SideC) / 2;
            double S = (p * (p - SideA) * (p - SideB) * (p - SideC));
            double S2 = Math.Sqrt(S);
            Console.WriteLine($"Площадь треугольника: {S2}");
        }
        public double TrianglePerimeter(double a, double b, double c)
        {   //Расчет периметра треугольника
            double p = (a + b + c) / 2;
            return p;
        }
        public void TrianglePerimeter2()
        {   //Вывод периметра треугольника
            double p = (SideA + SideB + SideC) / 2;
            Console.WriteLine($"Периметр треугольника: {p}");
        }
    }
    internal class Program
    {      
        static void Main(string[] args)
        {
            Triangle triangleCalculation = new Triangle(3,4,5);
            // Методы
            double sum = triangleCalculation.AreaOfTriangle(triangleCalculation.SideA, triangleCalculation.SideB, triangleCalculation.SideC);
            double sum2 = triangleCalculation.TrianglePerimeter(triangleCalculation.SideA, triangleCalculation.SideB, triangleCalculation.SideC);
            // Вывод
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
            // Метода с выводом
            triangleCalculation.AreaOfTriangle2();
            triangleCalculation.TrianglePerimeter2();
            Console.ReadKey();
        }
    }
}
