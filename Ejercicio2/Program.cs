using System;

namespace Model
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            double numero1, numero2, numero3;
            Console.WriteLine("Ingrese el primer numero");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            numero3 = double.Parse(Console.ReadLine());
            Console.WriteLine("El promedio es: ");
            double promedio = (numero1 + numero2 + numero3) / 3;
            Console.WriteLine(promedio);

        }


    }
}