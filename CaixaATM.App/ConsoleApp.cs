using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using Serilog.Core;
using CaixaATM.Data.Repository;
using CaixaATM.Application.Services;
using CaixaATM.Domain;
using CaixaATM.Application.DTOs;
using System.Threading;

namespace CaixaATM.App
{
    class ConsoleApp
    {
        private readonly Logger _logger;
        private readonly IConfiguration _configuration;
        private readonly IATMRepository _repository;
        private readonly IAtendimentoATM _atendimentoATM;

        public ConsoleApp(Logger logger, IConfiguration configuration, IATMRepository repository,
            IAtendimentoATM atendimentoATM)
        {
            _logger = logger;
            _configuration = configuration;
            _repository = repository;
            _atendimentoATM = atendimentoATM;

            new Mock(_logger, _configuration, _repository).Load();
        }

        public void Run()
        {

            while (1 == 1)
            {
                try
                {
                    Console.Clear();
                    _logger.Information("Iniciando o atendimento...");
                    _logger.Information("");
                    _logger.Information("Seja bem vindo ao ATM.");
                    _logger.Information("Informe o seu CPF: ");
                    var cpf = Console.ReadLine();
                    _logger.Information("Informe o sua senha: ");
                    var senha = Console.ReadLine();

                    var cliente = _atendimentoATM.Autenticar(cpf, senha, Guid.NewGuid());

                    AtendimentoInicial(cliente);
                }
                catch (Exception ex)
                {
                    _logger.Error($"Exceção: {ex.GetType().FullName} | " +
                                 $"Mensagem: {ex.Message}");
                    _logger.Information("Pressione qualquer tecla para continuar");
                    Console.ReadLine();
                }
            }
        }

        private void AtendimentoInicial(ClienteDTO cliente)
        {
            string opcao;

            try
            {
                while (1 == 1)
                {
                    Console.Clear();
                    _logger.Information("Seja bem vindo " + cliente.Nome + "!");
                    _logger.Information("");
                    _logger.Information("Selecione a opção desejada:");
                    _logger.Information("1 - Saque");
                    _logger.Information("2 - Consultar Saldo na tela (Indisponível)");
                    _logger.Information("3 - Transferência entre contas do banco (Indisponível)");
                    _logger.Information("4 - Depósito (Indisponível)");
                    _logger.Information("0 - Sair");

                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            OpcaoSaque(cliente);
                            break;
                        //case "2":
                        //    OpcaoSaque(cliente);
                        //    break;
                        //case "3":
                        //    OpcaoSaque(cliente);
                        //    break;
                        //case "4":
                        //    OpcaoSaque(cliente);
                            //break;
                        case "0":
                            _logger.Information("Obrigado por utilizar os nossos caixas de auto atendimento!");
                            Thread.Sleep(4000);
                            break;
                        default:
                            break;
                    }

                    if (opcao == "0") break;
                }
            }
            catch (Exception ex)
            {
                _logger.Error($"Exceção: {ex.GetType().FullName} | " +
                             $"Mensagem: {ex.Message}");
                _logger.Information("Pressione qualquer tecla para sair");
                Console.ReadLine();
            }
        }

        private void OpcaoSaque(ClienteDTO cliente)
        {
            var contas = _atendimentoATM.ListarContasCliente(cliente.Cpf);

            string opcaoConta;

            try
            {
                while (1 == 1)
                {
                    Console.Clear();
                    _logger.Information("Selecione a conta para efetuar o saque:");
                    for (int i = 0; i < contas.Count; i++)
                    {
                        _logger.Information($"{i+1} - {contas[i].Conta} (R$ {contas[i].Saldo})");
                    }
                    _logger.Information($"{contas.Count+1} - Cancelar");

                    opcaoConta = Console.ReadLine();

                    _logger.Information($"Valor: ");

                    var valor = Console.ReadLine();

                    if (Convert.ToInt32(opcaoConta) > contas.Count) break;

                    var protocolo = _atendimentoATM.Sacar(contas[Convert.ToInt32(opcaoConta) - 1].Conta, Convert.ToDecimal(valor), Guid.NewGuid());

                    _logger.Information($"Saque realizado com sucesso. Protocolo atendimento: {protocolo.Id}");
                    break;
                
                }
            }
            catch (Exception ex)
            {
                _logger.Error($"Exceção: {ex.GetType().FullName} | " +
                             $"Mensagem: {ex.Message}");
                _logger.Information("Pressione qualquer tecla para sair");
                Console.ReadLine();
            }
        }
    }
}
