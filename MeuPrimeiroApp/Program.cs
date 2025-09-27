using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

// aula de variáveis

// namespace: recurso usado para organizar e agrupar tipos relacionados,
// como classes, estruturas, interfaces, enumerações e delegados, 
// dentro de um contâiner(bloco) lógico

// ajuda a evitar conflitos de nomes, especialmente em projetos grandes ou quando biliotecas externas são utilizadas.
// por exemplo, o .NET Framework utiliza namespaces para organizar suas classes.

namespace EstruturasRepeticao
{
    class EstRepeticao
    {
        static void Main(String[] args)
        {

            // exemplos: Estrutura de Repetição: WHILE
            int[] arInt = new int[] { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < arInt.Length)
            {
                int numero = arInt[i];
                Console.WriteLine(numero);
                i++;
            }

            // exemplos: Estrutura de Repetição FOR

        }
    }
}   