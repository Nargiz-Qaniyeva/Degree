using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kelvin kelvin = new Kelvin(273);
            Celsius selsi = new Celsius(0);
            Console.WriteLine(selsi.Degree);
        }
    }
    class Kelvin
    {
        public double  Degree { get; set; }
        public Kelvin(double kelvin)
        {
            Degree=kelvin;
        }
        //public static implicit operator Celsius(Kelvin K)
        //{
        //    return new Celsius(K.Degree);   
        //}
    }
    class Celsius
    {
        public double Degree { get; set; }
        public Celsius(double selsi)
        {
            Degree = selsi;
        }
        public static implicit operator Kelvin(Celsius C)
        {
            return new Kelvin(C.Degree);
        }

    }
}
