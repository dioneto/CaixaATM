using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using Serilog.Core;
using CaixaATM.Data.Repository;
using CaixaATM.Data.Model;
using CaixaATM.Domain;

namespace CaixaATM.App
{
    public class Mock
    {
        private readonly Logger _logger;
        private readonly IATMRepository _repository;

        public Mock(Logger logger, IConfiguration configuration
        , IATMRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public void Load()
        {
            _logger.Information("Iniciando carga dados testes...");

            try
            {
                _repository.Incluir(new ATM("3631"));
                _repository.Incluir(new ATM("3632"));
                _repository.Incluir(new ATM("3633"));
                _repository.Incluir(new ATM("3634"));
                _repository.Incluir(new ATM("3635"));

                _repository.IncluirCliente(new Cliente("07723105215", "JOAO DA SILVA", DateTime.Parse("11/09/1987")));
                _repository.IncluirCliente(new Cliente("04666730192", "JOSE DA SILVA", DateTime.Parse("10/09/1987")));
                _repository.IncluirCliente(new Cliente("00868112070", "MARIA DA SILVA", DateTime.Parse("09/09/1987")));

                _repository.IncluirConta(new Conta(1234, _repository.ObterCliente("07723105215"), 1000));
                _repository.IncluirConta(new Conta(2234, _repository.ObterCliente("04666730192"), 10000));
                _repository.IncluirConta(new Conta(3234, _repository.ObterCliente("00868112070"), 100000));
            }
            catch (Exception ex)
            {
                _logger.Error($"Exceção: {ex.GetType().FullName} | " +
                             $"Mensagem: {ex.Message}");
            }

            _logger.Information("Carga de dados concluída com sucesso!");
        }


    }
}
