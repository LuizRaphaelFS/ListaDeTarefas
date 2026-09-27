using System;
using System.Collections.Generic;

namespace ListaDeTarefas
{
    class Sistema
    {
        static void Main(string[]args)
        {
            bool executando = true;
            List<string> tarefas = new List<string>();

            Console.WriteLine("=== Lista de Tarefas ===");
            Console.WriteLine();

            Console.WriteLine("Crie sua própria lista de tarefas simples!");
            Console.WriteLine();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();

            while (executando)
            {
                
            Console.WriteLine("1. Adicionar item à lista");
            Console.WriteLine("2. Excluir item da lista");
            Console.WriteLine("3. Ver lista de tarefas");
            Console.WriteLine("4. Encerrar o programa");
            Console.WriteLine();

            string escolha = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (escolha)
            {
                case "1":
                Console.WriteLine("Digite o nome da tarefa para a lista:");
                string novaTarefa = Console.ReadLine() ?? "";
                Console.WriteLine();

                tarefas.Add(novaTarefa);

                Console.WriteLine("Tarefa adicionada com sucesso!");
                Console.WriteLine();
                break;

                case "2":

                Console.WriteLine("Digite o nome de sua tarefa para a exclusão:");
                string excluirTarefa = Console.ReadLine() ?? "";
                Console.WriteLine();

                if (tarefas.Remove(excluirTarefa))
                {
                    Console.WriteLine("Tarefa removida com sucesso!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Tarefa não encontrada ou erro de digitação.");
                    Console.WriteLine();
                }

                break;

                case "3":

                if (tarefas.Count == 0)
                {
                    Console.WriteLine("Sua lista não possui nenhuma tarefa!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("--- Suas Tarefas ---");
                    Console.WriteLine();

                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        Console.WriteLine($"{i} - {tarefas[i]}");
                        Console.WriteLine();
                    }
                }

                break;

                case "4":

                Console.WriteLine("Finalizando programa...");
                Console.WriteLine();

                executando = false;
                break;

                default:

                Console.WriteLine("Opção inválida ou desconhecida. Tente novamente.:");
                Console.WriteLine();

                break;
            }
            }
        }
    }
}