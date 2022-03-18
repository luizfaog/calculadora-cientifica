using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha(100);
            string caracterUsuário;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Informe um número para empilhar ou um operador (+) (-) (*) (/)");
                caracterUsuário = Console.ReadLine();
                if (caracterUsuário == "+")
                {
                    int n1 = 0;
                    int n2 = 0;
                    int soma = 0;
                    n1 = p.Desempilhar();
                    n2 = p.Desempilhar();
                    soma = n1 + n2;
                    p.Empilhar(soma);
                    Console.WriteLine(soma);
                    

                }
                else if (caracterUsuário == "-" || caracterUsuário =="_")
                {
                    int n1 = 0, n2 = 0;
                    int subtracao;
                    n1 = p.Desempilhar();
                    n2 = p.Desempilhar();
                    subtracao = n2 - n1;
                    p.Empilhar(subtracao);
                    Console.WriteLine(subtracao);
                }
                else if (caracterUsuário == "*")
                {
                    int n1 =0, n2 = 0;
                    int multipli;
                    n1 = p.Desempilhar();
                    n2 = p.Desempilhar();
                    multipli = n2 * n1;
                    p.Empilhar(multipli);
                    Console.WriteLine(multipli);
                }
                else if (caracterUsuário == "/")
                {
                    int n1 = 0, n2 = 0;
                    int divisao;
                    n1 = p.Desempilhar();
                    n2 = p.Desempilhar();
                    divisao = n1 / n2;
                    p.Empilhar(divisao);
                    Console.WriteLine(divisao);
                }
                else
                {
                    p.Empilhar(int.Parse(caracterUsuário));
                }
            }
            Console.ReadLine();

        }
    }
}
