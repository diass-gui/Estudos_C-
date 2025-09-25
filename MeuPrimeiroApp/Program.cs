using System;
using Microsoft.VisualBasic;

// aula de variáveis

// namespace: recurso usado para organizar e agrupar tipos relacionados,
// como classes, estruturas, interfaces, enumerações e delegados, 
// dentro de um contâiner(bloco) lógico

// ajuda a evitar conflitos de nomes, especialmente em projetos grandes ou quando biliotecas externas são utilizadas.
// por exemplo, o .NET Framework utiliza namespaces para organizar suas classes.

namespace PrimeirosPassos
{
    class Nome
    {
        static void Main(String[] args)
        {

            // exemplos: tipos de dados, variáveis e constantes
            // int inteiro = 10;
            // float decimal1 = 10.9f;
            // double decimal2 = 20.9d;
            // decimal decimal3 = 30.9m; ;
            // bool boleano = decimal1 < decimal2;
            // char c1 = 'a';
            // string s = "Thaise";
            // var idade = 20;
            // const string nome = "Guilherme";

            // exemplos: Estruturas de decisão: IF-ELSE-ELSEIF
            const string APROVADO = "Aprovado!";
            const string REPROVADO = "Reprovado!";
            const string EM_RECUPERACAO = "Em Recuperação!";

            // readLine(); = Lê/recebe um atributo do usuário (funcionamento igual o scanner do java)
            // Convert.ToDecimal(); = recebe um atributo(alfa-numérico), e transforma ele em um dado númerico (int, decimal, etc)
            Console.WriteLine("Digite sua nota: ");
            decimal nota = Convert.ToDecimal(Console.ReadLine());

            if (nota >= 5)
            {
                Console.WriteLine(APROVADO);
            }
            else if (nota >= 4 && nota < 5)
            {
                Console.WriteLine(EM_RECUPERACAO);
            }
            else
            {
                Console.WriteLine(REPROVADO);
            }

            // exemplos: Estrututra de decisão: SWITCH-CASE
            const string DIAS_31 = "Este mês tem 31 dias!";
            const string DIAS_30 = "Este mês tem 30 dias!";
            const string DIAS_28 = "Este mês tem 28 dias!";
            const string MES_INVALIDO = "Este mês não existe";

            Console.WriteLine("Digite um mês: ");
            string mes = Console.ReadLine();

            switch (mes.ToUpper())
            {
                case "JANEIRO":
                    Console.WriteLine(DIAS_31);
                    break;
                case "FEVEREIRO":
                    Console.WriteLine(DIAS_28);
                    break;
                case "ABRIL":
                    Console.WriteLine(DIAS_30);
                    break;
                default:
                    Console.WriteLine(MES_INVALIDO);
                    break;
            }

        }
    }
}