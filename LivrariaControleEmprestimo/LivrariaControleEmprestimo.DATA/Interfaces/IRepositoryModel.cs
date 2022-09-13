namespace LivrariaControleEmprestimo.DATA.Interfaces
{
    public interface IRepositoryModel<T> where T : class
    {
        List<T> SelecionarTodos();

        T SelecionarPk(params object[] variavel);

        T Incluir(T obj);

        T Alterar(T obj);

        void Excluir(T obj);

        void Excluir(params object[] variavel);

        void SaveChanges();


    }
}
