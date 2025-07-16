using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeFuncaionarios.Entidades;
using ControleDeFuncaionarios.Repositorios;

namespace ControleDeFuncaionarios.Controladores
{
    /// <summary>
    /// Controller class for managing employee operations.
    /// </summary>
    public class FuncionarioControlador
    {
        public void CadastrarFuncionario()
        {
            #region Consultando as empresas cadastradas no banco de dados

            var empresaRepositorio = new EmpresaRepositorio();
            var empresas = empresaRepositorio.ObterEmpresas();

            foreach (var empresa in empresas)
            {
                Console.WriteLine($"ID: {empresa.Id}, Razão Social: {empresa.RazaoSocial}, CNPJ: {empresa.Cnpj}");
            }

            #endregion

            #region Inserindo um funcionário no banco de dados

            var funcionario = new Funcionario();

            Console.WriteLine("\n - CADASTRO DE FUNCIONÁRIOS: -\n:");

            Console.Write("Nome do funcionário...: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("CPF do funcionário.....: ");
            funcionario.Cpf = Console.ReadLine();

            Console.Write("Matrícula do funcionário...: ");
            funcionario.Matricula = Console.ReadLine();

            Console.Write("Data de admissão...: ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.Write("ID da empresa...: ");
            funcionario.EmpresaId = Guid.Parse(Console.ReadLine());

            var funcionarioRepositorio = new FuncionarioRepositorio();
            funcionarioRepositorio.InserirFuncionario(funcionario);
            Console.WriteLine("\nFuncionário cadastrado com sucesso!\n");

            #endregion
        }
    }
}
