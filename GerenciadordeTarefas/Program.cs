using System;

class Program
{
    static void Main()
    {
        var gerenciador = new GerenciadorDeTarefas();
        while (true)
        {
            Console.WriteLine("\n1. Adicionar");
            Console.WriteLine("2. Excluir");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Listar");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Descrição: ");
                    gerenciador.Adicionar(Console.ReadLine());
                    break;
                case "2":
                    Console.Write("ID da tarefa: ");
                    gerenciador.Excluir(int.Parse(Console.ReadLine()));
                    break;
                case "3":
                    Console.Write("ID da tarefa: ");
                    int idEditar = int.Parse(Console.ReadLine());
                    Console.Write("Nova descrição: ");
                    gerenciador.Editar(idEditar, Console.ReadLine());
                    break;
                case "4":
                    gerenciador.Listar();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
