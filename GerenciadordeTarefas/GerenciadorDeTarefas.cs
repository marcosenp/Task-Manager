using System;
using System.Collections.Generic;
using System.Linq;

public class GerenciadorDeTarefas
{
    private List<Tarefa> tarefas = new();
    private int proximoId = 1;

    public void Adicionar(string descricao)
    {
        var tarefa = new Tarefa(proximoId++, descricao);
        tarefas.Add(tarefa);
        Console.WriteLine("Tarefa adicionada com sucesso.");
    }

    public void Listar()
    {
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
            return;
        }

        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"{tarefa.Id} - {tarefa.Descricao}");
        }
    }

    public void Excluir(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null)
        {
            tarefas.Remove(tarefa);
            Console.WriteLine("Tarefa excluída.");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    public void Editar(int id, string novaDescricao)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null)
        {
            tarefa.Descricao = novaDescricao;
            Console.WriteLine("Tarefa editada.");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }
}
