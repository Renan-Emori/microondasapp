using Microondas.Models;

namespace Microondas.Repository
{
    public interface IPreDefinidoRepository
    {
        PreDefinidoModel ListarPorId(int id); 
        List<PreDefinidoModel> BuscarTodos();
        PreDefinidoModel Adicionar(PreDefinidoModel preDefinido);
        PreDefinidoModel Atualizar(PreDefinidoModel preDefinido);

        bool Apagar(int id);
    }
}
