using SDS.Catalogo.API.Models;
using SDS.Core.Data;

namespace SDS.Identidade.API.Models;

public interface IProdutoRepository : IRepository<Produto>
{
    Task<IEnumerable<Produto>> ObterTodos();
    Task<Produto> ObterPorId(Guid id);
    void Adicionar(Produto produto);
    void Atualizar(Produto produto);
}
