using System;
using System.Collections.Generic;

namespace semana1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            // Problema1();
            //Problema2();
            //Problema4();
            Problema6();
        }
        public static void Problema1()
        {
            int precio;
            Console.WriteLine("Ingrese el precio del producto");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine($"El precio final es de ${precio*1.15}");
            Console.ReadKey();
        }

        public static void Problema2() {
            string nombre;
            float nota;
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            while( nombre.ToUpper() != "FIN" )
            {
                nota = 0;
                for( int i = 0; i < 3; i++ )
                {
                    Console.WriteLine("Ingrese la nota");
                    nota += int.Parse(Console.ReadLine());
                }
                if( nota >= 80 ) {
                    Console.WriteLine($"el participante {nombre} con {nota} puntos ha clasificado");
                }
                Console.WriteLine("Ingrese el nombre");
                nombre = Console.ReadLine();
            }
        }

        public static void Problema4() {
            int numero;
            int divisor = 10;
            int suma = 0;
            Console.WriteLine("Ingrese un numero entero positivo");
            numero = int.Parse(Console.ReadLine()); 

            while( numero > 0 )
            {
                suma += numero % divisor;
                numero = (int)(numero / divisor);
                Console.WriteLine(numero);
            }
            Console.WriteLine($"Suma de digitos: {suma} ");

        }

        public static void Problema6()
        {
            int index = 0;
            float mayorInversion = 0;
            float suma = 0;
            List<string> nombres = new List<string>();
            List<float> aportes = new List<float>();
            for( int i = 0;i < 3;i++ )
            {
                Console.WriteLine("Ingrese el nombre");
                nombres.Add(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la inversión");
                float inversion = float.Parse(Console.ReadLine());
                aportes.Add(inversion);
                suma += inversion;

                if( inversion > mayorInversion )
                {
                    mayorInversion = inversion;
                    index = i;
                }
            }
            Console.WriteLine($"La mayor inversion la realizó {nombres[index]} con un {aportes[index]/suma*100} %");
        }
    }
}
