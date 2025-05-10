using Xunit;

namespace GerenciadorDeTarefasTests
{
    public class GerenciadorDeTarefasTests
    {
        [Fact]
        public void Adicionar_DeveAdicionarTarefaComDescricaoCorreta()
        {
            var gerenciador = new GerenciadorDeTarefas();
            var descricao = "Estudar C#";

            gerenciador.Adicionar(descricao);

            Assert.Contains(gerenciador.Tarefas, t => t.Descricao == descricao);
        }

        [Fact]
        public void Excluir_DeveRemoverTarefaDaLista()
        {
            var gerenciador = new GerenciadorDeTarefas();
            gerenciador.Adicionar("Tarefa para excluir");

            gerenciador.Excluir(1);

            Assert.Empty(gerenciador.Tarefas);
        }

        [Fact]
        public void Editar_DeveAlterarDescricaoDaTarefa()
        {
            var gerenciador = new GerenciadorDeTarefas();
            gerenciador.Adicionar("Descrição antiga");

            gerenciador.Editar(1, "Nova descrição");

            var tarefa = gerenciador.Tarefas.FirstOrDefault(t => t.Id == 1);
            Assert.Equal("Nova descrição", tarefa.Descricao);
        }

    }
}
