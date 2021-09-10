using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Calculadora
    {

        public static double Pi = 3.14;

        public static double Circunferencia(double raio)
        {
            return raio * Pi * 2;
        }

        public static double Volume(double raio)
        {
            return 4 / 3 * Pi * Math.Pow(raio, 3);
        }

        public static double ConversorDeMoeda(double cotacao, double valor)
        {
            return cotacao * valor * 1.06;
        }

        public static int Soma(params int[] numeros)
        {
            int soma = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma;
        }

        public static int Triplo(int origem,out int numero)
        {
            return numero = origem * 3;
        }
    }
}
