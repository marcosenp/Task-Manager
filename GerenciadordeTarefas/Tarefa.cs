public class Tarefa
{
    public int Id { get; set; }
    public string Descricao { get; set; }

    public Tarefa(int id, string descricao)
    {
        Id = id;
        Descricao = descricao;
    }
}
