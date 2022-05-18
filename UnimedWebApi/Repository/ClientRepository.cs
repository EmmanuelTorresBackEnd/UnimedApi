
using System.Collections.Generic;
using System.Linq;
using UnimedWebApi.Contexts;
using UnimedWebApi.Models;

namespace UnimedWebApi.Repositories
{
    public class ClienteRepository
    {
        private readonly UnimedContext _unimedContext;

        public ClienteRepository(UnimedContext context)
        {
            _unimedContext = context;
        }
        public List<Cliente> Listar()
        {
            return _unimedContext.Cliente.ToList();
        }

        public Cliente BuscarPorId(int id)
        {
            return _unimedContext.Cliente.Find(id);
        }


        public void Cadastrar (Cliente cliente)
        {
            _unimedContext.Cliente.Add(cliente);

            _unimedContext.SaveChanges();
        }
        
        public void Atualizar (int id, Cliente cliente)
        {
            Cliente clienteBuscado = _unimedContext.Cliente.Find(id);

            if (clienteBuscado != null)
            {
                clienteBuscado.Nome = cliente.Nome;
                clienteBuscado.CPF = cliente.CPF;
                clienteBuscado.Endereco = cliente.Endereco;
                clienteBuscado.NomeDaMae = cliente.NomeDaMae;
                clienteBuscado.IdCarteirinha = cliente.IdCarteirinha;
                clienteBuscado.NomeDoPlano = cliente.NomeDoPlano;
            }
            _unimedContext.Cliente.Update(clienteBuscado);
            _unimedContext.SaveChanges();
        }
        /// <summary>
        /// Deleta um Cliente existente a partir do Id
        /// </summary>
        /// <param name="id"></param>
        public void Deletar(int id)
        {
            Cliente clienteBuscado = _unimedContext.Cliente.Find(id);

            _unimedContext.Cliente.Remove(clienteBuscado);

            _unimedContext.SaveChanges();
        }
            
    }
}
