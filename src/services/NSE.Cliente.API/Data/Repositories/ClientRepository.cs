using Microsoft.EntityFrameworkCore;
using NSE.Clientes.API.Models;
using NSE.Clientes.API.Models.Repositories;
using NSE.Core.Data;

namespace NSE.Clientes.API.Data.Repositories
{
    public class ClientRepository : IClienteRepository
    {
        private readonly ClientesContext _context;

        public ClientRepository(ClientesContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }

        public async Task<Cliente> ObterPorCpf(string cpf)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c => c.Cpf.Numero == cpf);
        }

        public async Task<IEnumerable<Cliente>> ObterTodos()
        {
            return await _context.Clientes.AsNoTracking().ToListAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
