using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeFuncaionarios.Configuracoes;
using ControleDeFuncaionarios.Entidades;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ControleDeFuncaionarios.Repositorios
{
    /// <summary>
    /// Repository class for managing employee data.
    /// </summary>
    public class FuncionarioRepositorio
    {
        public void InserirFuncionario(Funcionario funcionario)
        {
            var query = @"
                        INSERT INTO FUNCIONARIO (ID, NOME, CPF, MATRICULA, DATAADMISSAO, EMPRESAID) 
                        VALUES (@Id, @Nome, @Cpf, @Matricula, @dataAdmissao, @EmpresaId)
                        ";
            var config = new ConfiguracaoDB();

            using (var connection = new SqlConnection(config.ConnectionString))
            {
                connection.Execute(query, funcionario);
            }
        }
    }
}
