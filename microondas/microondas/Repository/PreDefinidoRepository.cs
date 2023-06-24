using Microondas.Data;
using Microondas.Models;

namespace Microondas.Repository
{
    public class PreDefinidoRepository : IPreDefinidoRepository
    {
        private readonly BancoContext _bancoContext;
        public PreDefinidoRepository(BancoContext bancoContext) 
        {
            this._bancoContext = bancoContext;
        }
        public List<PreDefinidoModel> BuscarTodos()
        {
            return _bancoContext.PreDefinidoModel.ToList();
        }

        public PreDefinidoModel Adicionar(PreDefinidoModel preDefinido)
        {
            //gravar no banco de dados
            _bancoContext.PreDefinidoModel.Add(preDefinido);
            _bancoContext.SaveChanges();
            return preDefinido;
        }

        public PreDefinidoModel ListarPorId(int id)
        {
            return _bancoContext.PreDefinidoModel.FirstOrDefault(x => x.Id == id);
        }

        public PreDefinidoModel Atualizar(PreDefinidoModel preDefinido)
        {
            PreDefinidoModel preDefinidoDB = ListarPorId(preDefinido.Id);
            if (preDefinidoDB == null) throw new Exception("Houve um erro na atualização do contato");
            preDefinidoDB.Nome = preDefinido.Nome;
            preDefinidoDB.Alimento = preDefinido.Alimento;
            preDefinidoDB.Tempo = preDefinido.Tempo;
            preDefinidoDB.Potencia = preDefinido.Potencia;
            preDefinidoDB.Instrucoes = preDefinido.Instrucoes;

            _bancoContext.PreDefinidoModel.Update(preDefinidoDB);
            _bancoContext.SaveChanges();

            return preDefinidoDB;
        }

        public bool Apagar(int id)
        {
            PreDefinidoModel preDefinidoDB = ListarPorId(id);
            if (preDefinidoDB == null) throw new Exception("Houve um erro na deleção do contato");

            _bancoContext.PreDefinidoModel.Remove(preDefinidoDB);
            _bancoContext.SaveChanges();    
            return true;
        }
    }
}
