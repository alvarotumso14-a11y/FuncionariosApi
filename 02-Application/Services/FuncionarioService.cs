using Application.DTos;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepositorio _repository;

        public FuncionarioService(IFuncionarioRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<FuncionarioOutputDto> CreateAsync(FuncionarioInputDto dto)
        {
            var funcionario = new Funcionario
            {
                Nome = dto.Nome,
                Cargo = dto.Cargo,
                Salario = dto.Salario,
                Departamento = dto.Departamento,
                Ativo = true
            };

            await _repository.AddAsync(funcionario);
            await _repository.SaveChangesAsync();

            return new FuncionarioOutputDto
            {
                Id = funcionario.Id,
                Nome = funcionario.Nome,
                Cargo = funcionario.Cargo,
                Salario = funcionario.Salario,
                Departamento = funcionario.Departamento,
                Ativo = funcionario.Ativo
            };
        }

        public Task<IEnumerable<FuncionarioOutputDto>> GetAllAsync()
            => throw new NotImplementedException();

        public Task<FuncionarioOutputDto> GetByIdAsync(int id)
            => throw new NotImplementedException();

        public Task UpdateAsync(int id, FuncionarioInputDto dto)
            => throw new NotImplementedException();

        public Task DeleteAsync(int id)
       => throw new NotImplementedException();
    }
}
