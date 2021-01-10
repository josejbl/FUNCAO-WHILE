using System;

namespace FUNCAO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apredendo While");

            Console.WriteLine("Digite um número");
            decimal numero = decimal.Parse(Console.ReadLine());

             decimal i = 0;

             Console.WriteLine("------------------------------" );

            //While repete enquanto a condição for verdaira
            while(i <= numero)
            {
                 Console.WriteLine(i);
                 //contador = contador + 24;// incremento
                 // contador ++ ;
                 i = i + (0.1m);

            }//fim do While

        }
    }
}
