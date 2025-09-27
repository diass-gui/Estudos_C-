using System;
using Microsoft.VisualBasic;
/*
namespace EstruturasDecisao
{

    class EstDecisao {
        static void Main(String[] args)
        {

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
*/