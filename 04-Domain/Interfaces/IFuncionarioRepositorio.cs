using _04_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IFuncionarioRepositorio
    {
        Task<IEnumerable<Funcionario>> GetAllAsync();
        Task<Funcionario> GetByIdAsync(int id);
        Task AddAsync(Funcionario funcionario);
        void Update(Funcionario funcionario);
        void Delete(Funcionario funcionario);
        Task SaveChangesAsync();
    }
}
