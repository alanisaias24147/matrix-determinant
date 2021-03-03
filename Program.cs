using System;
using System.Security.Cryptography.X509Certificates;

namespace matrix_determinant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;
            matriz[1, 0] = 3;
            matriz[1, 1] = 4;
            matriz[1, 2] = 5;
            matriz[2, 0] = 5;
            matriz[2, 1] = 6;
            matriz[2, 2] = 9;

            Console.WriteLine( (matriz[0, 0], matriz[0, 1], matriz[0, 2]) );
            Console.WriteLine( (matriz[1, 0], matriz[1, 1], matriz[1, 2]) );
            Console.WriteLine( (matriz[2, 0], matriz[2, 1], matriz[2, 2]) );

            int uno = matriz[0, 0] * matriz[1, 1] * matriz[2, 2];
            int dos = matriz[1, 0] * matriz[2, 1] * matriz[0, 2];
            int tres = matriz[2, 0] * matriz[1, 1] * matriz[1, 2];
            int cuatro = matriz[0, 2] * matriz[2, 1] * matriz[2, 0];
            int cinco = matriz[1, 2] * matriz[2, 1] * matriz[0, 0];
            int seis = matriz[2, 2] * matriz[0, 1] * matriz[1, 0];

            int determinante = (uno + dos + tres) - (cuatro + cinco + seis);
            Console.WriteLine("El determinante de la matriz es " +  determinante);

        }
    }
}
