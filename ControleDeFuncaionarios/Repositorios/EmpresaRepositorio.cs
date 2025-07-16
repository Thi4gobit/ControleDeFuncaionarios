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
    /// Repository class for managing company data.
    /// </summary>
    public class EmpresaRepositorio
    {
        public List<Empresa> ObterEmpresas()
        {
            var query = @"
                        SELECT ID, RAZAOSOCIAL, CNPJ 
                        FROM EMPRESA 
                        ORDER BY RAZAOSOCIAL
                        ";

            var config = new ConfiguracaoDB();

            using (var connection = new SqlConnection(config.ConnectionString))
            {
                return connection.Query<Empresa>(query).ToList();
            }
        }
    }
}
