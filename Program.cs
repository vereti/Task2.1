using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cone
{
    class Cone
    {
        public Cone(double radius_, double height_)
        {
            radius = radius_;
            height = height_;
            square = Math.Pow(radius, 2) * Math.PI;
            amount = square * height / 3;
        }

        public double AmountOfCylinder()
        {
            return amount * 3;
        }

        public double AmountOfCone(double h)
        {
            return amount - (Math.Pow((height - h) * radius / height, 2) *
                Math.PI * (height - h) / 3);
        }

        public double getRadius()
        {
            return radius;
        }

        public double getHeight()
        {
            return height;
        }

        public double getSquare()
        {
            return square;
        }

        public double getAmount()
        {
            return amount;
        }


        double radius;
        double height;

        double square; //auto
        double amount; //auto
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Cone cone = new Cone(r, h);
            Console.WriteLine("Радиус = {0}", cone.getRadius());
            Console.WriteLine("Высота = {0}", cone.getHeight());
            Console.WriteLine("Площадь основания = {0}", cone.getSquare());
            Console.WriteLine("Общий объем = {0}", cone.getAmount());
            Console.WriteLine("Объем цилиндра = {0}", cone.AmountOfCylinder());
            Console.Write("Введите расстояние от основания до параллельной плоскости: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Объем нижней части конуса = {0}", cone.AmountOfCone(h));
            Console.ReadKey();
        }
    }
}
