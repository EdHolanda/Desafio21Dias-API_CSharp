using System;
using System.Collections.Generic;

namespace Desafio21Dias_API_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Valkiria é a diretora da escola Mundo Melhor.
            Ela precisa de um programa que armazene alunos com suas matrículas e notas em uma tabela
            No final, ela tem a necessidade de saber se o aluno foi aprovado ou não
            Faça um programa para resolver a questão da Valkiria*/

            
            Console.WriteLine("Bem vinda, Valkiria!\n");
            var opcao = "s";
            var nome = "";
            var matricula = "";
            var resultado = "";
            List<dynamic> alunos = new List<dynamic>();
            while(opcao.ToLower() == "s")
            {
                Console.WriteLine("Digite o nome do aluno:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a matrícula do aluno:");
                matricula = Console.ReadLine();
                Console.WriteLine("Digite as notas do aluno:");
                double[] notas = new double[3];
                double soma = 0;
                double media = 0;
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{i + 1}ª nota:");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    soma += notas[i];
                }
                media = soma/notas.Length;
                if(media >= 7)
                {
                    resultado = "Aprovado";
                }
                else
                {
                    resultado = "Reprovado";
                }
                alunos.Add(new{
                    Nome = nome,
                    Matricula = matricula,
                    Notas = notas,
                    Media = media,
                    Situacao = resultado
                });
                
                Console.Clear();
                Console.WriteLine("Cadastrar outro aluno? s/n");
                opcao = Console.ReadLine();
            }
            Console.Clear();
            foreach(var aluno in alunos)
            {
                Console.WriteLine("────────────────────────────────");
                Console.WriteLine($"Nome: {aluno.Nome} - Matrícula: {aluno.Matricula}");
                Console.WriteLine("────────────────────────────────");
                Console.WriteLine($"Notas:");
                int n = 1;
                foreach(double nota in aluno.Notas)
                {
                    Console.WriteLine($"{n}ª nota: {nota}");
                    n += 1;
                }
                Console.WriteLine($"Média: {Math.Round(aluno.Media,1)} - Situação: {aluno.Situacao}");
            }
            Console.WriteLine("────────────────────────────────");




        // Aula 3 exemplo loop infinito   
        // while(true)
        // {
        //   Console.WriteLine("Digite\n1 - para sair\n0 - para continuar");
        //   int sair = Convert.ToInt32(Console.ReadLine());
        //   if(sair == 1) break;
        //   else if(sair == 2) continue;

        //   Console.WriteLine("Opaaaa estou por aqui");
        // }


           //Aula 3
            // Console.WriteLine("Número Inicial");
            // int numeroInicial = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Número Final");
            // int numeroFinal = Convert.ToInt32(Console.ReadLine());
            
            // int indice = numeroInicial;
            // while(indice <= numeroFinal)
            // {
            //     Console.WriteLine(indice);
            //     indice++;
            // }
            
            // for(int i = numeroInicial;i <= numeroFinal; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // int[] itens = new int[]{1,2,3,4,5,6,7,8,9,10};

            // foreach (int item in itens)
            // {
            //     Console.WriteLine(item);
            // }




            // return;
            
            
            
            
            
            
            
            /*

            Aula 2
            Console.WriteLine("Digite o primeiro número");
            var numeroUm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int numeroDois = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Qual o resultado da soma entre os números {numeroUm} e {numeroDois}?");


            int resultado = Convert.ToInt32(Console.ReadLine());

            var soma = numeroUm + numeroDois;

            if(soma == resultado)
            {
                Console.WriteLine($"Parabéns você acertou o resultado: {resultado}");
            }
            else
            {
                Console.WriteLine($"Você errou, o resultado correto é {soma}, tente novamente");
            }

        int caseSwitch = 2;

        if(caseSwitch == 1)
        {
            Console.WriteLine("Case 1");
        }
        else if(caseSwitch == 2)
        {
            Console.WriteLine("Case 2");
        }
        else
        {
            Console.WriteLine("Default case");
        }


        switch (caseSwitch)
        {
            case 1:
                Console.WriteLine("Case 1");
                break;
            case 2:
                Console.WriteLine("Case 2");
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }


        */    
        }
    }
}
